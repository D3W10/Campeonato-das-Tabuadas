using System;
using System.Windows.Forms;

namespace Campeonato_das_Tabuadas
{
    public partial class Notebook : Form
    {
        public Notebook()
        {
            InitializeComponent();
        }

        private void tbTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || (tbTab.Text.Length == 0 && e.KeyChar == '0'))
                e.Handled = true;
        }

        private void tbTab_TextChanged(object sender, EventArgs e)
        {
            int tab = tbTab.Text.Length == 0 ? 1 : Convert.ToInt32(tbTab.Text);

            lblTab1.Text = tab + " × 1 = " + (tab * 1);
            lblTab2.Text = tab + " × 2 = " + (tab * 2);
            lblTab3.Text = tab + " × 3 = " + (tab * 3);
            lblTab4.Text = tab + " × 4 = " + (tab * 4);
            lblTab5.Text = tab + " × 5 = " + (tab * 5);
            lblTab6.Text = tab + " × 6 = " + (tab * 6);
            lblTab7.Text = tab + " × 7 = " + (tab * 7);
            lblTab8.Text = tab + " × 8 = " + (tab * 8);
            lblTab9.Text = tab + " × 9 = " + (tab * 9);
            lblTab10.Text = tab + " × 10 = " + (tab * 10);
            lblTab11.Text = tab + " × 11 = " + (tab * 11);
            lblTab12.Text = tab + " × 12 = " + (tab * 12);
        }
    }
}