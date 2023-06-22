using Campeonato_das_Tabuadas.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato_das_Tabuadas
{
    public partial class Dashboard : Form
    {
        public bool goBack = false;
        private static DirectoryInfo appDataFolder = new(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Application.ProductName);
        private static FileInfo registFile = new(appDataFolder.FullName + "\\data.json");

        public Dashboard()
        {
            InitializeComponent();

            tcPages.Appearance = TabAppearance.FlatButtons;
            tcPages.ItemSize = new Size(0, 1);
            tcPages.SizeMode = TabSizeMode.Fixed;
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

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcPages.SelectedIndex == 1)
            {
                tTime.Enabled = false;
                e.Cancel = true;

                DialogResult closeWarn = MessageBox.Show("Tem a certeza que quer terminar o jogo atual? As respostas certas e erradas não serão contabilizadas.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (closeWarn == DialogResult.Yes)
                    EndGame();
                else
                    tTime.Enabled = true;
            }
        }

        private void btnAwards_Click(object sender, EventArgs e)
        {
            if (tcPages.SelectedIndex != 2)
            {
                lvwAwards.Items.Clear();

                int obtainedCnt = 0;
                List<AwardData> awardList = AwardController.GetAllAwardsData();
                JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(registFile.FullName));

                foreach (AwardData award in awardList)
                {
                    bool obtained = Convert.ToBoolean(classObject.Awards.GetType().GetProperty(award.Id).GetValue(classObject.Awards, null));

                    ListViewItem listViewItem = new()
                    {
                        ImageKey = award.Id + ".png",
                        Tag = award.Id,
                        UseItemStyleForSubItems = false
                    };
                    listViewItem.SubItems.Add(award.Name);

                    ListViewItem.ListViewSubItem listViewSubItem = new()
                    {
                        Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point),
                        ForeColor = obtained ? Color.LimeGreen : Color.Red,
                        Text = obtained ? "✔️" : "❌"
                    };
                    listViewItem.SubItems.Add(listViewSubItem);

                    if (obtained)
                        obtainedCnt++;

                    lvwAwards.Items.Add(listViewItem);
                }

                lblAwardsCnt.Text = obtainedCnt + " / " + awardList.Count;
                if (obtainedCnt == awardList.Count)
                    lblAwardsCnt.ForeColor = Color.Gold;

                tcPages.SelectedIndex = 2;
            }
            else
                tcPages.SelectedIndex = 0;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            new Calculator().ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goBack = true;
            Close();
        }

        private void btnNotebook_Click(object sender, EventArgs e)
        {
            new Notebook().ShowDialog();
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
                pbNTabuada.Image = Properties.Resources.tabuadaTodas;
        }

        private void tbTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || (tbTabuada.Text.Length == 0 && e.KeyChar == '0'))
                e.Handled = true;
        }

        private void lvwAwards_Click(object sender, EventArgs e)
        {
            if (lvwAwards.SelectedItems.Count != 0)
            {
                List<AwardData> awardList = AwardController.GetAllAwardsData();
                AwardData award = awardList.Find(award => award.Id == (string)lvwAwards.SelectedItems[0].Tag);

                MessageBox.Show(award.Description, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                lvwAwards.SelectedItems.Clear();
            }
        }

        private void lvwAwards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space)
                lvwAwards_Click(null, null);
        }

        private void lvwAwards_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lvwAwards.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        #region Game

        private int tab = 0, problemResult = 0, problemN = 0, timeTick = 0;
        private bool startMode = false, onVerifyProcess = false;
        private Dictionary<int, List<int>> tabCombinations = new();

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbbTabuada.SelectedItem.ToString() == "Outra" && tbTabuada.Text.Length == 0)
            {
                MessageBox.Show("Tens de inserir uma tabuada na caixa de texto!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTabuada.Focus();
                return;
            }

            if (cbbTabuada.SelectedItem.ToString() == "Outra" && Convert.ToInt32(tbTabuada.Text) == 0)
            {
                MessageBox.Show("Acho que devias saber que qualquer número a multiplicar por 0 é sempre 0...", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTabuada.Clear();
                tbTabuada.Focus();
                return;
            }

            tcPages.SelectedIndex = 1;
            lblProblemN.Text = "0 / " + nudQtd.Value;
            lblTime.Text = "00:00";
            lblCorrect.Text = "0";
            lblWrong.Text = "0";
            pgbCompletition.Value = 0;
            lblProblem.Text = "3";
            tTime.Enabled = true;
            pSide.Enabled = false;
            tbAnswer.Visible = false;
            startMode = true;

            tab = Convert.ToInt32(cbbTabuada.SelectedItem.ToString() == "Outra" ? tbTabuada.Text : (cbbTabuada.SelectedItem.ToString() == "Todas" ? "-1" : cbbTabuada.SelectedItem.ToString()));

            BuildTabCombinations();
        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            if (++timeTick != 10)
                return;

            timeTick = 0;

            if (startMode)
            {
                if (Convert.ToInt32(lblProblem.Text) - 1 == 0)
                {
                    tbAnswer.Visible = true;
                    startMode = false;
                    GenerateProblem();
                }
                else
                    lblProblem.Text = (Convert.ToInt32(lblProblem.Text) - 1).ToString();
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

                lblTime.Text = timePartsNum[0].ToString("00") + ":" + timePartsNum[1].ToString("00");
            }
        }

        private void BuildTabCombinations()
        {
            if (tab != -1)
                tabCombinations.Add(tab, Enumerable.Range(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value)).ToList());
            else
            {
                for (int i = (int)nudMin.Value; i <= nudMax.Value; i++)
                    tabCombinations.Add(i, Enumerable.Range(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value)).ToList());
            }
        }

        private void GenerateProblem()
        {
            if (tabCombinations.Count == 0)
                BuildTabCombinations();

            if (problemN == nudQtd.Value)
            {
                EndGame();
                return;
            }

            Random randomNumber = new();
            int random1 = randomNumber.Next(0, tabCombinations.Count);
            int random2 = cbShuffle.Checked ? randomNumber.Next(0, tabCombinations.ElementAt(random1).Value.Count) : 0;

            int value1, value2;
            value1 = tabCombinations.ElementAt(random1).Key;
            value2 = tabCombinations.ElementAt(random1).Value[random2];

            tabCombinations.ElementAt(random1).Value.RemoveAt(random2);
            if (tabCombinations.ElementAt(random1).Value.Count == 0)
                tabCombinations.Remove(tabCombinations.ElementAt(random1).Key);

            lblProblemN.Text = ++problemN + " / " + nudQtd.Value;
            tbAnswer.ForeColor = Color.Black;
            tbAnswer.Clear();
            tbAnswer.Focus();

            if (!cbComutative.Checked || randomNumber.Next(0, 2) == 0)
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
                e.Handled = true;
                onVerifyProcess = true;
                if (tbAnswer.Text.Length == 0)
                {
                    onVerifyProcess = false;
                    return;
                }

                if (Convert.ToInt32(tbAnswer.Text) == problemResult)
                {
                    tbAnswer.ForeColor = Color.LimeGreen;
                    lblCorrect.Text = (Convert.ToInt32(lblCorrect.Text) + 1).ToString();
                }
                else
                {
                    tbAnswer.ForeColor = Color.Red;
                    lblWrong.Text = (Convert.ToInt32(lblWrong.Text) + 1).ToString();
                }

                tTime.Enabled = false;
                pgbCompletition.Value = Convert.ToInt32(problemN * 100 / nudQtd.Value);
                await Task.Delay(1000);
                tTime.Enabled = true;
                onVerifyProcess = false;

                GenerateProblem();
            }
        }

        private async void EndGame()
        {
            JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(registFile.FullName));

            tcPages.SelectedIndex = 0;
            tTime.Enabled = false;

            if (Convert.ToInt32(lblCorrect.Text) >= nudQtd.Value * 0.8m)
            {
                pbWinLose.Image = Properties.Resources.win;
                lblNoGameInfo.Text = "Boa, conseguiste acertar um bom número de tabuadas. Continua assim!";
            }
            else
            {
                pbWinLose.Image = Properties.Resources.sad;
                lblNoGameInfo.Text = "Estás a precisar de praticar. Estuda um bocado e volta a tentar!";
            }

            AwardController.CheckForWonAward(ref classObject, new AwardDiscriminator
            {
                correct = Convert.ToInt32(lblCorrect.Text),
                wrong = Convert.ToInt32(lblWrong.Text),
                tab = tab,
                qtd = nudQtd.Value,
                min = nudMin.Value,
                max = nudMax.Value,
                shuffle = cbShuffle.Checked,
                comutative = cbComutative.Checked,
                minutes = Convert.ToInt32(lblTime.Text.Split(":")[0]),
                seconds = Convert.ToInt32(lblTime.Text.Split(":")[1])
            }, ref ilAwards);

            await File.WriteAllTextAsync(registFile.FullName, JsonSerializer.Serialize(classObject));

            problemN = 0;
            timeTick = 0;
            tabCombinations.Clear();
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

        public bool F3 { get; set; }

        public bool F4 { get; set; }
    }
}