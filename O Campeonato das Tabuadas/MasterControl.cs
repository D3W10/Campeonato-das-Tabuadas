using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_Campeonato_das_Tabuadas
{
    public partial class MasterControl : Form
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\O Campeonato das Tabuadas\\Data.json";
        public bool goBack = false;

        public MasterControl()
        {
            InitializeComponent();
        }

        private void MasterControl_Load(object sender, EventArgs e)
        {
            if (new FileInfo(path).Exists == false)
            {
                MessageBox.Show("O modo aprendiz deve ser aberto pelo menos 1 vez antes de tentar abrir o Controlo Mestre. Por favor inicie no modo aprendiz.", "O Campeonato das Tabuadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goBack = true;
                Close();
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            goBack = true;
            Close();
        }

        private async void btnPoints_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende reiniciar o registo de respostas corretas e erradas?\nEsta ação não pode ser desfeita!", "O Campeonato das Tabuadas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(path));
                classObject.TotalCorrect = 0;
                classObject.TotalWrong = 0;
                await File.WriteAllTextAsync(path, JsonSerializer.Serialize(classObject));
            }
        }

        private async void btnAwards_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende remover todas as medalhas recebidas?\nEsta ação não pode ser desfeita!", "O Campeonato das Tabuadas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(path));
                classObject.Awards.A1 = false;
                classObject.Awards.A1G = false;
                classObject.Awards.A1R = false;
                classObject.Awards.A2 = false;
                classObject.Awards.A2G = false;
                classObject.Awards.A2R = false;
                classObject.Awards.A3 = false;
                classObject.Awards.A3G = false;
                classObject.Awards.A3R = false;
                classObject.Awards.A4 = false;
                classObject.Awards.A4G = false;
                classObject.Awards.A4R = false;
                classObject.Awards.A5 = false;
                classObject.Awards.A5G = false;
                classObject.Awards.A5R = false;
                classObject.Awards.A6 = false;
                classObject.Awards.A6G = false;
                classObject.Awards.A6R = false;
                classObject.Awards.A7 = false;
                classObject.Awards.A7G = false;
                classObject.Awards.A7R = false;
                classObject.Awards.A8 = false;
                classObject.Awards.A8G = false;
                classObject.Awards.A8R = false;
                classObject.Awards.A9 = false;
                classObject.Awards.A9G = false;
                classObject.Awards.A9R = false;
                classObject.Awards.AX = false;
                classObject.Awards.AXG = false;
                classObject.Awards.AXR = false;
                classObject.Awards.C100 = false;
                classObject.Awards.C300 = false;
                classObject.Awards.C1000 = false;
                classObject.Awards.T30 = false;
                classObject.Awards.T10 = false;
                classObject.Awards.F1 = false;
                classObject.Awards.F2 = false;
                await File.WriteAllTextAsync(path, JsonSerializer.Serialize(classObject));
            }
        }

        private async void btnShuffle_Click(object sender, EventArgs e)
        {
            JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(path));
            btnShuffle.Font = new Font(btnShuffle.Font, FontStyle.Bold);
            if (classObject.ShuffleLock)
                btnShuffle.ForeColor = Color.FromArgb(232, 42, 57);
            else
                btnShuffle.ForeColor = Color.FromArgb(34, 185, 119);
            classObject.ShuffleLock = !classObject.ShuffleLock;
            await File.WriteAllTextAsync(path, JsonSerializer.Serialize(classObject));
            await Task.Delay(1000);
            btnShuffle.Font = new Font(btnShuffle.Font, FontStyle.Regular);
            btnShuffle.ForeColor = Color.Black;
        }

        private async void btnComutative_Click(object sender, EventArgs e)
        {
            JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(path));
            btnComutative.Font = new Font(btnComutative.Font, FontStyle.Bold);
            if (classObject.ComutativeLock)
                btnComutative.ForeColor = Color.FromArgb(232, 42, 57);
            else
                btnComutative.ForeColor = Color.FromArgb(34, 185, 119);
            classObject.ComutativeLock = !classObject.ComutativeLock;
            await File.WriteAllTextAsync(path, JsonSerializer.Serialize(classObject));
            await Task.Delay(1000);
            btnComutative.Font = new Font(btnComutative.Font, FontStyle.Regular);
            btnComutative.ForeColor = Color.Black;
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende remover completamente o registo? O mesmo inclui dados como o total de respostas certas e erradas, medalhas e definições do Master Control.\nEsta ação não pode ser desfeita!", "O Campeonato das Tabuadas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                new FileInfo(path).Delete();
                MessageBox.Show("O registo foi apagado com sucesso, a aplicação vai agora reiniciar.", "O Campeonato das Tabuadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goBack = true;
                Close();
            }
        }
    }
}