using Multiplication_Championship.Properties;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Multiplication_Championship
{
    public partial class Welcome : Form
    {
        public string logInType = null;
        private readonly ResourceManager resources = new(typeof(Welcome));

        public Welcome()
        {
            InitializeComponent();

            tcPages.Appearance = TabAppearance.FlatButtons;
            tcPages.ItemSize = new Size(0, 1);
            tcPages.SizeMode = TabSizeMode.Fixed;
        }

        private void btnApprentice_Click(object sender, EventArgs e)
        {
            logInType = "Apprentice";
            Close();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            tcPages.SelectedIndex = 1;
            tbPassword.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcPages.SelectedIndex = 0;
            btnApprentice.Focus();
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
            if (tbPassword.Text == Resources.masterPassword)
            {
                logInType = "Master";
                Close();
            }
            else
                MessageBox.Show(resources.GetString("loginMessage"), Resources.appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}