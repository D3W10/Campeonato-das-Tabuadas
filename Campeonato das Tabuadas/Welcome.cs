using System;
using System.Drawing;
using System.Windows.Forms;

namespace Campeonato_das_Tabuadas
{
    public partial class Welcome : Form
    {
        public string logInType = null;

        public Welcome()
        {
            InitializeComponent();

            tcPages.Appearance = TabAppearance.FlatButtons;
            tcPages.ItemSize = new Size(0, 1);
            tcPages.SizeMode = TabSizeMode.Fixed;
        }

        private void btnAprendiz_Click(object sender, EventArgs e)
        {
            logInType = "Aprendiz";
            Close();
        }

        private void btnMestre_Click(object sender, EventArgs e)
        {
            tcPages.SelectedIndex = 1;
            tbPassword.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcPages.SelectedIndex = 0;
            btnAprendiz.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CheckLogin();
        }

        private void CheckLogin()
        {
            if (tbPassword.Text == "mestredastabuadas")
            {
                logInType = "Mestre";
                Close();
            }
            else
                MessageBox.Show("A palavra-passe inserida está incorreta!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}