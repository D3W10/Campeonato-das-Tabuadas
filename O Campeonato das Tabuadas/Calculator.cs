using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace O_Campeonato_das_Tabuadas
{
    public partial class Calculator : Form
    {
        private char operador;
        private bool canBeCleared = false, lastWasEquals = false;
        private decimal value1 = 0, value2 = 0;
        private Color selectedOperation = Color.FromArgb(215, 215, 215);

        public Calculator()
        {
            InitializeComponent();

            int radius = 10;
            Rectangle rectangle = new Rectangle(0, 0, pbPlus.Width, pbPlus.Height);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90);
            pbPlus.Region = new Region(graphicsPath);
            pbMinus.Region = new Region(graphicsPath);
            pbTimes.Region = new Region(graphicsPath);
            pbDivide.Region = new Region(graphicsPath);
            pbPercentage.Region = new Region(graphicsPath);
        }

        private void pbNumber0_Click(object sender, EventArgs e)
        {
            NumberClick(0);
        }

        private void pbNumber1_Click(object sender, EventArgs e)
        {
            NumberClick(1);
        }

        private void pbNumber2_Click(object sender, EventArgs e)
        {
            NumberClick(2);
        }

        private void pbNumber3_Click(object sender, EventArgs e)
        {
            NumberClick(3);
        }

        private void pbNumber4_Click(object sender, EventArgs e)
        {
            NumberClick(4);
        }

        private void pbNumber5_Click(object sender, EventArgs e)
        {
            NumberClick(5);
        }

        private void pbNumber6_Click(object sender, EventArgs e)
        {
            NumberClick(6);
        }

        private void pbNumber7_Click(object sender, EventArgs e)
        {
            NumberClick(7);
        }

        private void pbNumber8_Click(object sender, EventArgs e)
        {
            NumberClick(8);
        }

        private void pbNumber9_Click(object sender, EventArgs e)
        {
            NumberClick(9);
        }

        private void NumberClick(int number)
        {
            pbPlus.BackColor = Color.Transparent;
            pbMinus.BackColor = Color.Transparent;
            pbTimes.BackColor = Color.Transparent;
            pbDivide.BackColor = Color.Transparent;
            pbPercentage.BackColor = Color.Transparent;

            if (canBeCleared || lblDisplay.Text == "0")
            {
                lblDisplay.Text = number.ToString();
                canBeCleared = false;
            }
            else
                lblDisplay.Text += number.ToString();

            lastWasEquals = false;
        }

        private void pbPeriod_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += ",";
            lastWasEquals = false;
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (!canBeCleared)
            {
                if (lblDisplay.Text.Length == 1 && lblDisplay.Text != "0")
                    lblDisplay.Text = "0";
                else if (lblDisplay.Text.Length > 1)
                    lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
                lastWasEquals = false;
            }
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            operador = 'N';
            value1 = 0;
            value2 = 0;
            lastWasEquals = false;
        }

        private void lblDisplay_TextChanged(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 10)
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
        }

        private void pbPlus_Click(object sender, EventArgs e)
        {
            OperatorClick('+');
        }

        private void pbMinus_Click(object sender, EventArgs e)
        {
            OperatorClick('-');
        }

        private void pbTimes_Click(object sender, EventArgs e)
        {
            OperatorClick('*');
        }

        private void pbDivide_Click(object sender, EventArgs e)
        {
            OperatorClick('/');
        }

        private void pbPercentage_Click(object sender, EventArgs e)
        {
            OperatorClick('%');
        }

        private void OperatorClick(char toOperator)
        {
            pbPlus.BackColor = Color.Transparent;
            pbMinus.BackColor = Color.Transparent;
            pbTimes.BackColor = Color.Transparent;
            pbDivide.BackColor = Color.Transparent;
            pbPercentage.BackColor = Color.Transparent;

            if (toOperator == '+')
                pbPlus.BackColor = selectedOperation;
            else if (toOperator == '-')
                pbMinus.BackColor = selectedOperation;
            else if (toOperator == '*')
                pbTimes.BackColor = selectedOperation;
            else if (toOperator == '/')
                pbDivide.BackColor = selectedOperation;
            else if (toOperator == '%')
                pbPercentage.BackColor = selectedOperation;
            value1 = Convert.ToDecimal(lblDisplay.Text);
            operador = toOperator;
            canBeCleared = true;
            lastWasEquals = false;
        }

        private void pbEquals_Click(object sender, EventArgs e)
        {
            if (!lastWasEquals)
                value2 = Convert.ToDecimal(lblDisplay.Text);
            else
                value1 = Convert.ToDecimal(lblDisplay.Text);

            if (operador == '+')
                lblDisplay.Text = Convert.ToString(value1 + value2);
            else if (operador == '-')
                lblDisplay.Text = Convert.ToString(value1 - value2);
            else if (operador == '*')
                lblDisplay.Text = Convert.ToString(value1 * value2);
            else if (operador == '/')
                lblDisplay.Text = Convert.ToString(value1 / value2);
            else if (operador == '%')
                lblDisplay.Text = Convert.ToString(value1 % value2);

            lastWasEquals = true;
            canBeCleared = true;
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
                NumberClick(0);
            else if (e.KeyChar == '1')
                NumberClick(1);
            else if (e.KeyChar == '2')
                NumberClick(2);
            else if (e.KeyChar == '3')
                NumberClick(3);
            else if (e.KeyChar == '4')
                NumberClick(4);
            else if (e.KeyChar == '5')
                NumberClick(5);
            else if (e.KeyChar == '6')
                NumberClick(6);
            else if (e.KeyChar == '7')
                NumberClick(7);
            else if (e.KeyChar == '8')
                NumberClick(8);
            else if (e.KeyChar == '9')
                NumberClick(9);
            else if (e.KeyChar == '.')
                pbPeriod_Click(null, null);
            else if (e.KeyChar == '+')
                OperatorClick('+');
            else if (e.KeyChar == '-')
                OperatorClick('-');
            else if (e.KeyChar == '*')
                OperatorClick('*');
            else if (e.KeyChar == '/')
                OperatorClick('/');
            else if (e.KeyChar == '%')
                OperatorClick('%');
            else if (e.KeyChar == (char)Keys.Back)
                pbDelete_Click(null, null);
            else if (e.KeyChar == 'c' || e.KeyChar == 'C')
                pbClear_Click(null, null);
            else if (e.KeyChar == (char)Keys.Enter)
                pbEquals_Click(null, null);
        }
    }
}