using System;
using System.Windows.Forms;

namespace O_Campeonato_das_Tabuadas
{
    public partial class Welcome : Form
    {
        public string logInType = null;

        public Welcome()
        {
            InitializeComponent();
        }

        private void btnAprendiz_Click(object sender, EventArgs e)
        {
            logInType = "Aprendiz";
            Close();
        }

        private void btnMestre_Click(object sender, EventArgs e)
        {
            pWelcome.Visible = false;
            tbPassword.Focus();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            pWelcome.Visible = true;
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
                MessageBox.Show("A palavra-passe inserida está incorreta!", "O Campeonato das Tabuadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}