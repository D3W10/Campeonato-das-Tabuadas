using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multiplication_Championship.Classes;
using Multiplication_Championship.Properties;

namespace Multiplication_Championship
{
    public partial class Dashboard : Form
    {
        public bool goBack = false;
        private static readonly DirectoryInfo appDataFolder = new(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Application.ProductName);
        private static readonly FileInfo registFile = new(appDataFolder.FullName + "\\data.json");
        private readonly ResourceManager resources = new(typeof(Dashboard));

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

            cbbMultiplication.SelectedIndex = 1;
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

                DialogResult closeWarn = MessageBox.Show(resources.GetString("closeInGameMessage"), Resources.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                        ImageKey = award.Id,
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
            tbMultiplication.Enabled = false;
            tbMultiplication.PlaceholderText = "";
            tbMultiplication.Clear();

            if (cbbMultiplication.SelectedIndex == 0)
                pbNMultiplication.Image = Resources.tabuada1;
            else if (cbbMultiplication.SelectedIndex == 1)
                pbNMultiplication.Image = Resources.tabuada2;
            else if (cbbMultiplication.SelectedIndex == 2)
                pbNMultiplication.Image = Resources.tabuada3;
            else if (cbbMultiplication.SelectedIndex == 3)
                pbNMultiplication.Image = Resources.tabuada4;
            else if (cbbMultiplication.SelectedIndex == 4)
                pbNMultiplication.Image = Resources.tabuada5;
            else if (cbbMultiplication.SelectedIndex == 5)
                pbNMultiplication.Image = Resources.tabuada6;
            else if (cbbMultiplication.SelectedIndex == 6)
                pbNMultiplication.Image = Resources.tabuada7;
            else if (cbbMultiplication.SelectedIndex == 7)
                pbNMultiplication.Image = Resources.tabuada8;
            else if (cbbMultiplication.SelectedIndex == 8)
                pbNMultiplication.Image = Resources.tabuada9;
            else if (cbbMultiplication.SelectedIndex == 9)
            {
                pbNMultiplication.Image = Resources.tabuadaX;
                tbMultiplication.Enabled = true;
                tbMultiplication.PlaceholderText = "12";
            }
            else if (cbbMultiplication.SelectedIndex == 10)
                pbNMultiplication.Image = Resources.tabuadaTodas;
        }

        private void tbTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || (tbMultiplication.Text.Length == 0 && e.KeyChar == '0'))
                e.Handled = true;
        }

        private void lvwAwards_Click(object sender, EventArgs e)
        {
            if (lvwAwards.SelectedItems.Count != 0)
            {
                List<AwardData> awardList = AwardController.GetAllAwardsData();
                AwardData award = awardList.Find(award => award.Id == (string)lvwAwards.SelectedItems[0].Tag);

                MessageBox.Show(award.Description, Resources.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private readonly Dictionary<int, List<int>> tabCombinations = new();

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbbMultiplication.SelectedIndex == 9)
            {
                if (tbMultiplication.Text.Length == 0)
                {
                    MessageBox.Show(resources.GetString("noMultiplicationMessage"), Resources.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMultiplication.Focus();
                    return;
                }
                else if (!int.TryParse(tbMultiplication.Text, out int tabCheck))
                {
                    MessageBox.Show(resources.GetString("noNumberMessage"), Resources.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMultiplication.Clear();
                    tbMultiplication.Focus();
                    return;
                }
                else if (tabCheck == 0)
                {
                    MessageBox.Show(resources.GetString("noZeroMessage"), Resources.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMultiplication.Clear();
                    tbMultiplication.Focus();
                    return;
                }
            }

            tcPages.SelectedIndex = 1;
            lblProblemN.Text = "0 / " + nudQty.Value;
            lblTime.Text = "00:00";
            lblCorrect.Text = "0";
            lblWrong.Text = "0";
            pgbCompletition.Value = 0;
            lblProblem.Text = "3";
            tTime.Enabled = true;
            pSide.Enabled = false;
            tbAnswer.Visible = false;
            startMode = true;

            tab = Convert.ToInt32(cbbMultiplication.SelectedIndex == 9 ? tbMultiplication.Text : (cbbMultiplication.SelectedIndex == 10 ? "-1" : cbbMultiplication.SelectedItem.ToString()));

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

            if (problemN == nudQty.Value)
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

            lblProblemN.Text = ++problemN + " / " + nudQty.Value;
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
                pgbCompletition.Value = Convert.ToInt32(problemN * 100 / nudQty.Value);
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

            if (Convert.ToInt32(lblCorrect.Text) >= nudQty.Value * 0.8m)
            {
                pbWinLose.Image = Resources.win;
                lblNoGameInfo.Text = resources.GetString("winMessage");
            }
            else
            {
                pbWinLose.Image = Resources.sad;
                lblNoGameInfo.Text = resources.GetString("loseMessage");
            }

            AwardController.CheckForWonAward(ref classObject, new AwardDiscriminator
            {
                correct = Convert.ToInt32(lblCorrect.Text),
                wrong = Convert.ToInt32(lblWrong.Text),
                tab = tab,
                qtd = nudQty.Value,
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