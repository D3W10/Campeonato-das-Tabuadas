using System;
using System.Drawing;
using System.Windows.Forms;

namespace Campeonato_das_Tabuadas
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