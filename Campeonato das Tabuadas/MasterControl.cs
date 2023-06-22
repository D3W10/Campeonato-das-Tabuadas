using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato_das_Tabuadas
{
    public partial class MasterControl : Form
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Application.ProductName + "\\data.json";
        public bool goBack = false;

        public MasterControl()
        {
            InitializeComponent();
        }

        private void MasterControl_Load(object sender, EventArgs e)
        {
            if (new FileInfo(path).Exists == false)
            {
                MessageBox.Show("O modo aprendiz deve ser aberto pelo menos 1 vez antes de tentar abrir o Controlo Mestre. Por favor inicie no modo aprendiz.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                goBack = true;
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goBack = true;
            Close();
        }

        private async void btnPoints_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende reiniciar o registo de respostas corretas e erradas?\nEsta ação não pode ser desfeita!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende remover todas as medalhas recebidas?\nEsta ação não pode ser desfeita!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(path));

                foreach (PropertyInfo property in classObject.Awards.GetType().GetProperties())
                    property.SetValue(classObject.Awards, false);

                await File.WriteAllTextAsync(path, JsonSerializer.Serialize(classObject));
            }
        }

        private async void btnShuffle_Click(object sender, EventArgs e)
        {
            JSONFormat classObject = JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(path));

            btnShuffle.Font = new Font(btnShuffle.Font, FontStyle.Bold);
            if (classObject.ShuffleLock)
                btnShuffle.ForeColor = Color.Red;
            else
                btnShuffle.ForeColor = Color.LimeGreen;

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
                btnComutative.ForeColor = Color.Red;
            else
                btnComutative.ForeColor = Color.LimeGreen;

            classObject.ComutativeLock = !classObject.ComutativeLock;
            await File.WriteAllTextAsync(path, JsonSerializer.Serialize(classObject));
            await Task.Delay(1000);

            btnComutative.Font = new Font(btnComutative.Font, FontStyle.Regular);
            btnComutative.ForeColor = Color.Black;
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende remover completamente o registo? O mesmo inclui dados como o total de respostas certas e erradas, medalhas e definições do Master Control.\nEsta ação não pode ser desfeita!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                new FileInfo(path).Delete();
                MessageBox.Show("O registo foi apagado com sucesso, a aplicação vai agora reiniciar.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                goBack = true;
                Close();
            }
        }
    }
}