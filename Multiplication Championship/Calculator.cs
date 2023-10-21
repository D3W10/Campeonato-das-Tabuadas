using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Multiplication_Championship
{
    public partial class Calculator : Form
    {
        private char? operador;
        private bool canOverwrite = false, equalsPressed = false;
        private decimal lastValue;
        private decimal? value1 = null, value2 = null;

        public Calculator()
        {
            InitializeComponent();
        }

        private decimal GetDisplayValue()
        {
            return Convert.ToDecimal(lblDisplay.Text == "Erro" ? "0" : lblDisplay.Text);
        }

        private void SetDisplayValue(string value, bool append)
        {
            if (!append)
                lblDisplay.Text = value;
            else
                lblDisplay.Text += value;
        }

        #region Number Buttons

        private void btnNum0_Click(object sender, EventArgs e)
        {
            NumberClick(0);
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            NumberClick(1);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            NumberClick(2);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            NumberClick(3);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            NumberClick(4);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            NumberClick(5);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            NumberClick(6);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            NumberClick(7);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            NumberClick(8);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            NumberClick(9);
        }

        #endregion

        private void NumberClick(int number)
        {
            btnPlus.BackColor = Color.Transparent;
            btnMinus.BackColor = Color.Transparent;
            btnTimes.BackColor = Color.Transparent;
            btnDivide.BackColor = Color.Transparent;

            if (canOverwrite || lblDisplay.Text == "0")
            {
                SetDisplayValue(number.ToString(), false);
                canOverwrite = false;
            }
            else
                SetDisplayValue(number.ToString(), true);

            equalsPressed = false;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            char decimalSep = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (canOverwrite)
            {
                lblDisplay.Text = "0" + decimalSep;
                canOverwrite = false;
            }
            else if (!lblDisplay.Text.Contains(decimalSep))
                lblDisplay.Text += decimalSep;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDisplayValue("0", false);
            operador = null;
            btnPlus.BackColor = Color.Transparent;
            btnMinus.BackColor = Color.Transparent;
            btnTimes.BackColor = Color.Transparent;
            btnDivide.BackColor = Color.Transparent;
            value1 = null;
            value2 = null;
            canOverwrite = false;
            equalsPressed = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!canOverwrite)
            {
                if (lblDisplay.Text.Length == 1 && GetDisplayValue() != 0)
                    SetDisplayValue("0", false);
                else if (lblDisplay.Text.Length > 1)
                    lblDisplay.Text = lblDisplay.Text[..^1];

                equalsPressed = false;
            }
            else
                btnClear_Click(null, null);
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!canOverwrite)
            {
                if (GetDisplayValue() != 0 && !lblDisplay.Text.StartsWith("-"))
                    lblDisplay.Text = "-" + lblDisplay.Text;
                else if (GetDisplayValue() != 0 && lblDisplay.Text.StartsWith("-"))
                    lblDisplay.Text = lblDisplay.Text.Replace("-", "");
            }
            else
                btnClear_Click(null, null);
        }

        private void lblDisplay_TextChanged(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 10)
                lblDisplay.Text = lblDisplay.Text[..^1];
        }

        #region Operation Buttons

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OperatorClick('+');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OperatorClick('-');
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            OperatorClick('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperatorClick('/');
        }

        #endregion

        private void OperatorClick(char toOperator)
        {
            btnPlus.BackColor = Color.Transparent;
            btnMinus.BackColor = Color.Transparent;
            btnTimes.BackColor = Color.Transparent;
            btnDivide.BackColor = Color.Transparent;

            if (toOperator == '+')
                btnPlus.BackColor = Color.LightGray;
            else if (toOperator == '-')
                btnMinus.BackColor = Color.LightGray;
            else if (toOperator == '*')
                btnTimes.BackColor = Color.LightGray;
            else if (toOperator == '/')
                btnDivide.BackColor = Color.LightGray;

            if (value1 != null && value1 != GetDisplayValue())
                btnEquals_Click(null, null);

            value1 = GetDisplayValue();
            operador = toOperator;
            canOverwrite = true;
            equalsPressed = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!equalsPressed)
            {
                value2 = GetDisplayValue();
                lastValue = GetDisplayValue();
            }
            else
            {
                value1 = GetDisplayValue();
                value2 = lastValue;
            }

            try
            {
                if (operador == '+')
                    SetDisplayValue((value1 + value2).ToString(), false);
                else if (operador == '-')
                    SetDisplayValue((value1 - value2).ToString(), false);
                else if (operador == '*')
                    SetDisplayValue((value1 * value2).ToString(), false);
                else if (operador == '/')
                    SetDisplayValue((value1 / value2).ToString(), false);
            }
            catch (DivideByZeroException)
            {
                lblDisplay.Text = "Erro";
            }

            value1 = value2 = null;
            equalsPressed = true;
            canOverwrite = true;
        }

        private void ButtonsPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEquals.Focus();
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

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
            else if (e.KeyChar == ',' || e.KeyChar == '.')
                btnPeriod_Click(null, null);
            else if (e.KeyChar == '+')
                OperatorClick('+');
            else if (e.KeyChar == '-')
                OperatorClick('-');
            else if (e.KeyChar == '*')
                OperatorClick('*');
            else if (e.KeyChar == '/')
                OperatorClick('/');
            else if (e.KeyChar == (char)Keys.Back)
                btnDelete_Click(null, null);
            else if (e.KeyChar == 'c' || e.KeyChar == 'C')
                btnClear_Click(null, null);
        }
    }
}