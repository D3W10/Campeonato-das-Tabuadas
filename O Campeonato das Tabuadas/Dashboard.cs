using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_Campeonato_das_Tabuadas
{
    public partial class Dashboard : Form
    {
        public bool goBack = false;
        private static DirectoryInfo appDataFolder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\O Campeonato das Tabuadas");
        private static FileInfo registFile = new FileInfo(appDataFolder.FullName + "\\Data.json");

        public Dashboard()
        {
            InitializeComponent();
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            JSONFormat classObject;

            cbbTabuada.SelectedIndex = 1;
            if (!appDataFolder.Exists)
                appDataFolder.Create();
            if (registFile.Exists)
                classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(registFile.FullName));
            else
                classObject = new JSONFormat();

            if (classObject.ShuffleLock)
            {
                cbShuffle.Checked = true;
                cbShuffle.Enabled = false;
            }
            if (classObject.ComutativeLock)
            {
                cbComutative.Checked = true;
                cbComutative.Enabled = false;
            }

            await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));
        }

        private void pbCalculator_Click(object sender, EventArgs e)
        {
            new Calculator().ShowDialog();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            goBack = true;
            Close();
        }

        private void cbbTabuada_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTabuada.Enabled = false;
            if (cbbTabuada.SelectedItem.ToString() == "1")
                pbNTabuada.Image = Properties.Resources.tabuada1;
            else if (cbbTabuada.SelectedItem.ToString() == "2")
                pbNTabuada.Image = Properties.Resources.tabuada2;
            else if (cbbTabuada.SelectedItem.ToString() == "3")
                pbNTabuada.Image = Properties.Resources.tabuada3;
            else if (cbbTabuada.SelectedItem.ToString() == "4")
                pbNTabuada.Image = Properties.Resources.tabuada4;
            else if (cbbTabuada.SelectedItem.ToString() == "5")
                pbNTabuada.Image = Properties.Resources.tabuada5;
            else if (cbbTabuada.SelectedItem.ToString() == "6")
                pbNTabuada.Image = Properties.Resources.tabuada6;
            else if (cbbTabuada.SelectedItem.ToString() == "7")
                pbNTabuada.Image = Properties.Resources.tabuada7;
            else if (cbbTabuada.SelectedItem.ToString() == "8")
                pbNTabuada.Image = Properties.Resources.tabuada8;
            else if (cbbTabuada.SelectedItem.ToString() == "9")
                pbNTabuada.Image = Properties.Resources.tabuada9;
            else if (cbbTabuada.SelectedItem.ToString() == "Outra")
            {
                pbNTabuada.Image = Properties.Resources.tabuadaX;
                tbTabuada.Enabled = true;
            }
            else if (cbbTabuada.SelectedItem.ToString() == "Todas")
                pbNTabuada.Image = Properties.Resources.tabuadaX;
        }

        private void tbTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || (tbTabuada.Text.Length == 0 && e.KeyChar == '0'))
                e.Handled = true;
        }

        private void pbAwards_Click(object sender, EventArgs e)
        {
            if (pGame.Visible)
            {
                lvwAwards.Items.Clear();
                JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(registFile.FullName));
                foreach (PropertyInfo property in classObject.Awards.GetType().GetProperties())
                {
                    if (Convert.ToBoolean(classObject.Awards.GetType().GetProperty(property.Name).GetValue(classObject.Awards, null)))
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.ImageKey = classObject.Awards.GetType().GetProperty(property.Name).Name + ".png";
                        lvwAwards.Items.Add(listViewItem);
                    }
                }
            }
            pGame.Visible = !pGame.Visible;
        }

        private void pbNotebook_Click(object sender, EventArgs e)
        {
            new Notebook().ShowDialog();
        }

        #region Game

        private int tab = 0, problemResult = 0, problemN = 0;
        private bool startMode = false, onVerifyProcess = false;
        private List<int> originalOptions = null;
        private List<int> decreasingOptionsV1 = new List<int>();
        private List<int> decreasingOptionsV2 =  new List<int>();

        private void btnStart_Click(object sender, EventArgs e)
        {
            pGame.Visible = true;
            lblProblemN.Text = "0 / " + nudQtd.Value;
            lblProblemN.Visible = true;
            lblTime.Text = "00:00";
            lblTime.Visible = true;
            pbCorrect.Visible = true;
            lblCorrect.Text = "0";
            lblCorrect.Visible = true;
            pbWrong.Visible = true;
            lblWrong.Text = "0";
            lblWrong.Visible = true;
            pgbCompletition.Value = 0;
            pgbCompletition.Visible = true;

            if (cbbTabuada.SelectedItem.ToString() == "Outra" && tbTabuada.Text.Length == 0)
            {
                MessageBox.Show("Tens de inserir uma tabuada na caixa de texto!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tab = Convert.ToInt32(cbbTabuada.SelectedItem.ToString() == "Outra" ? tbTabuada.Text : (cbbTabuada.SelectedItem.ToString() == "Todas" ? "0" : cbbTabuada.SelectedItem.ToString()));
            lblProblem.Text = "3";
            tlpProblem.Visible = true;
            tTime.Enabled = true;
            pSide.Enabled = false;
            startMode = true;

            originalOptions = Enumerable.Range(0, Convert.ToInt32(nudMax.Value) + 1).ToList();
            decreasingOptionsV1 = originalOptions.GetRange(0, originalOptions.Count);
            decreasingOptionsV2 = originalOptions.GetRange(0, originalOptions.Count);
        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            if (startMode)
            {
                if (Convert.ToInt32(lblProblem.Text) - 1 == 0)
                {
                    startMode = false;
                    GenerateProblem();
                }
                else
                    lblProblem.Text = Convert.ToString(Convert.ToInt32(lblProblem.Text) - 1);
            }
            else
            {
                int[] timePartsNum = new int[2];
                string[] timeParts = lblTime.Text.Split(':');

                timePartsNum[0] = Convert.ToInt32(timeParts[0]);
                timePartsNum[1] = Convert.ToInt32(timeParts[1]);
                if (timePartsNum[1] == 59)
                {
                    timePartsNum[1] = 0;
                    if (timePartsNum[0] == 59)
                    {
                        EndGame();
                        return;
                    }
                    else
                        timePartsNum[0] += 1;
                }
                else
                    timePartsNum[1] += 1;
                timeParts[0] = timePartsNum[0].ToString().Length == 1 ? "0" + timePartsNum[0].ToString() : timePartsNum[0].ToString();
                timeParts[1] = timePartsNum[1].ToString().Length == 1 ? "0" + timePartsNum[1].ToString() : timePartsNum[1].ToString();
                lblTime.Text = string.Join(":", timeParts);
            }
        }

        private void GenerateProblem()
        {
            if (decreasingOptionsV1.Count == 0)
                decreasingOptionsV1 = originalOptions.GetRange(0, originalOptions.Count);
            if (decreasingOptionsV2.Count == 0)
                decreasingOptionsV2 = originalOptions.GetRange(0, originalOptions.Count);

            Random randomNumber = new Random();
            int random1 = cbShuffle.Checked ? randomNumber.Next(0, decreasingOptionsV1.Count) : 0;
            int random2 = randomNumber.Next(0, decreasingOptionsV2.Count + 1);

            int value1, value2;
            value1 = decreasingOptionsV1[random1];
            decreasingOptionsV1.RemoveAt(random1);
            if (cbbTabuada.SelectedItem.ToString() == "Todas")
            {
                value2 = decreasingOptionsV2[random2];
                decreasingOptionsV2.RemoveAt(random2);
            }
            else
                value2 = tab;

            if (problemN == nudQtd.Value)
            {
                EndGame();
                return;
            }
            lblProblemN.Text = ++problemN + " / " + nudQtd.Value;
            tbAnswer.ForeColor = Color.Black;
            tbAnswer.Visible = true;
            tbAnswer.Clear();
            tbAnswer.Focus();

            if (!cbComutative.Checked)
                lblProblem.Text = value1 + " × " + value2;
            else if (randomNumber.Next(0, 2) == 0)
                lblProblem.Text = value1 + " × " + value2;
            else
                lblProblem.Text = value2 + " × " + value1;
            problemResult = value1 * value2;
        }

        private async void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (onVerifyProcess)
                e.Handled = true;
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == (char)Keys.Enter)
            {
                onVerifyProcess = true;
                if (tbAnswer.Text.Length == 0)
                {
                    onVerifyProcess = false;
                    return;
                }
                if (Convert.ToInt32(tbAnswer.Text) == problemResult)
                {
                    tbAnswer.ForeColor = Color.FromArgb(34, 185, 119);
                    lblCorrect.Text = (Convert.ToInt32(lblCorrect.Text) + 1).ToString();
                }
                else
                {
                    tbAnswer.ForeColor = Color.FromArgb(232, 42, 57);
                    lblWrong.Text = (Convert.ToInt32(lblWrong.Text) + 1).ToString();
                }
                tTime.Enabled = false;
                pgbCompletition.Value = Convert.ToInt32((problemN * 100) / nudQtd.Value);
                await Task.Delay(1500);
                tTime.Enabled = true;
                onVerifyProcess = false;
                GenerateProblem();
            }
        }

        private async void EndGame()
        {
            JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(registFile.FullName));

            tTime.Enabled = false;
            if (Convert.ToInt32(lblWrong.Text) > Convert.ToInt32(lblCorrect.Text))
            {
                pbWinLose.Image = Properties.Resources.lose;
                lblNoGameInfo.Text = "Perdeste, erraste mais tabuadas do que as que acertaste. Volta a tentar!";
            }
            else
                lblNoGameInfo.Text = "Boa, conseguiste acertar um bom número de tabuadas. Continua assim!";
            
            if (nudQtd.Value == Convert.ToInt32(lblCorrect.Text) && nudQtd.Value >= 10 && nudMax.Value >= 9 && tab != 0)
            {
                string tabToSearch = tab > 9 ? "X" : tab.ToString();
                string extraSufix = "";
                if (cbShuffle.Checked)
                    extraSufix = "G";
                if (cbShuffle.Checked && cbComutative.Checked)
                    extraSufix = "R";

                if (!Convert.ToBoolean(classObject.Awards.GetType().GetProperty("A" + tabToSearch + extraSufix).GetValue(classObject.Awards, null)))
                {
                    classObject.Awards.GetType().GetProperty("A" + tabToSearch + extraSufix).SetValue(classObject.Awards, true);
                    await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

                    ShowAwardAlert("A" + tabToSearch + extraSufix + ".png");
                }
            }

            if (classObject.TotalCorrect + Convert.ToInt32(lblCorrect.Text) >= 1000 && !Convert.ToBoolean(classObject.Awards.C1000))
            {
                classObject.Awards.C1000 = true;
                await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

                ShowAwardAlert("C1000.png");
            }
            else if (classObject.TotalCorrect + Convert.ToInt32(lblCorrect.Text) >= 300 && !Convert.ToBoolean(classObject.Awards.C300))
            {
                classObject.Awards.C300 = true;
                await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

                ShowAwardAlert("C300.png");
            }
            else if (classObject.TotalCorrect + Convert.ToInt32(lblCorrect.Text) >= 100 && !Convert.ToBoolean(classObject.Awards.C100))
            {
                classObject.Awards.C100 = true;
                await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

                ShowAwardAlert("C100.png");
            }

            if (nudQtd.Value == Convert.ToInt32(lblCorrect.Text) && nudQtd.Value >= 10 && nudMax.Value >= 9 && cbShuffle.Checked && cbComutative.Checked && lblTime.Text.Split(':')[0] == "00" && Convert.ToInt32(lblTime.Text.Split(':')[1]) <= 10 && !Convert.ToBoolean(classObject.Awards.T10))
            {
                classObject.Awards.T10 = true;
                await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

                ShowAwardAlert("T10.png");
            }
            else if (nudQtd.Value == Convert.ToInt32(lblCorrect.Text) && nudQtd.Value >= 10 && nudMax.Value >= 9 && cbShuffle.Checked && cbComutative.Checked && lblTime.Text.Split(':')[0] == "00" && Convert.ToInt32(lblTime.Text.Split(':')[1]) <= 30 && !Convert.ToBoolean(classObject.Awards.T30))
            {
                classObject.Awards.T30 = true;
                await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

                ShowAwardAlert("T30.png");
            }

            if (nudQtd.Value == Convert.ToInt32(lblCorrect.Text) && nudQtd.Value >= 30 && nudMax.Value >= 9 && cbShuffle.Checked && cbComutative.Checked && tab == 0 && !Convert.ToBoolean(classObject.Awards.F2))
            {
                classObject.Awards.F2 = true;
                await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

                ShowAwardAlert("F2.png");
            }
            else if (nudQtd.Value == Convert.ToInt32(lblCorrect.Text) && nudQtd.Value >= 10 && nudMax.Value >= 9 && tab == 0 && lblTime.Text.Split(':')[0] == "00" && Convert.ToInt32(lblTime.Text.Split(':')[1]) <= 20 && !Convert.ToBoolean(classObject.Awards.F1))
            {
                classObject.Awards.F1 = true;
                await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

                ShowAwardAlert("F1.png");
            }

            pbWinLose.Visible = true;
            tlpProblem.Visible = false;
            tbAnswer.ForeColor = Color.Black;
            tbAnswer.Visible = false;
            tbAnswer.Clear();
            problemN = 0;
            pSide.Enabled = true;
            UpdateRegistFile();
        }

        private async void UpdateRegistFile()
        {
            JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(registFile.FullName));

            classObject.TotalCorrect += Convert.ToInt32(lblCorrect.Text);
            classObject.TotalWrong += Convert.ToInt32(lblWrong.Text);
            await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));
        }

        private void ShowAwardAlert(string imageSrc)
        {
            int imageIndex = 0;

            for (int i = 0; i < ilAwards.Images.Keys.Count; i++)
            {
                if (ilAwards.Images.Keys[i] == imageSrc)
                    imageIndex = i;
            }

            WonAward wonAward = new WonAward(ilAwards.Images[imageIndex]);
            wonAward.ShowDialog();
        }

        #endregion
    }

    public class JSONFormat
    {
        public JSONFormat()
        {
            TotalCorrect = 0;
            TotalWrong = 0;
            Awards = new AwardsStore();
        }

        public int TotalCorrect { get; set; }

        public int TotalWrong { get; set; }

        public bool ShuffleLock { get; set; }

        public bool ComutativeLock { get; set; }

        public AwardsStore Awards { get; set; }
    }

    public class AwardsStore
    {
        public bool A1 { get; set; }

        public bool A1G { get; set; }

        public bool A1R { get; set; }

        public bool A2 { get; set; }

        public bool A2G { get; set; }

        public bool A2R { get; set; }

        public bool A3 { get; set; }

        public bool A3G { get; set; }

        public bool A3R { get; set; }

        public bool A4 { get; set; }

        public bool A4G { get; set; }

        public bool A4R { get; set; }

        public bool A5 { get; set; }

        public bool A5G { get; set; }

        public bool A5R { get; set; }

        public bool A6 { get; set; }

        public bool A6G { get; set; }

        public bool A6R { get; set; }

        public bool A7 { get; set; }

        public bool A7G { get; set; }

        public bool A7R { get; set; }

        public bool A8 { get; set; }

        public bool A8G { get; set; }

        public bool A8R { get; set; }

        public bool A9 { get; set; }

        public bool A9G { get; set; }

        public bool A9R { get; set; }

        public bool AX { get; set; }

        public bool AXG { get; set; }

        public bool AXR { get; set; }

        public bool C100 { get; set; }

        public bool C300 { get; set; }

        public bool C1000 { get; set; }

        public bool T30 { get; set; }

        public bool T10 { get; set; }

        public bool F1 { get; set; }

        public bool F2 { get; set; }
    }
}