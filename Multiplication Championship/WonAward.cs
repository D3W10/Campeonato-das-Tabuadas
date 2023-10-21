using System;
using System.Drawing;
using System.Windows.Forms;

namespace Multiplication_Championship
{
    public partial class WonAward : Form
    {
        public WonAward(Image icon)
        {
            InitializeComponent();

            pbIcon.Image = icon;
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}