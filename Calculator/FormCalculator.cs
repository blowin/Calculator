using Calculator.Domain;
using System;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private bool _numberSign = true;
        private Domain.Calculator _calculator;

        public FormCalculator()
        {
            InitializeComponent();
            _calculator = new Domain.Calculator();
        }

        private (IDigit LeftValue, IDigit RightValue) GetValues()
        {
            return (SafeDigit(txtBoxValue.Text), SafeDigit(txtScoreboard.Text));

            static IDigit SafeDigit(string value)
            {
                if (string.IsNullOrWhiteSpace(value))
                    return new DecimalDigit(0);
                return new CacheDigit(new StringDigit(value));
            }
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Œ¯Ë·Í‡", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtScoreboard.Text == "0")
                txtScoreboard.Text = string.Empty;
            txtScoreboard.Text = txtScoreboard.Text + ((Button)sender).Text;
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            if (!txtScoreboard.Text.Contains(','))
                txtScoreboard.Text = txtScoreboard.Text + ',';
        }

        private void btnCleanEntry_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = string.Empty;
            txtBoxValue.Text = string.Empty;
            _calculator = new Domain.Calculator();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var length = txtScoreboard.Text.Length;
            if (length != 0)
                txtScoreboard.Text = txtScoreboard.Text.Remove(length - 1);
        }

        private void btnNumberSign_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = _numberSign ? "-" + txtScoreboard.Text : txtScoreboard.Text.Replace("-", ""); 
            _numberSign = !_numberSign;
        }
        
        private void btnArithmeticOperation_Click(object sender, EventArgs e)
        {
            try
            {
                var (left, right) = GetValues();
                var operation = char.Parse(((Button)sender).Text);

                var valueTxtBox = _calculator.Eval(left, right, operation);

                txtBoxValue.Text = valueTxtBox.ToString();
                txtScoreboard.Text = string.Empty;
            }
            catch (Exception exception)
            {
                ShowError(exception.Message);
            }
        }
        
        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            var (left, right) = GetValues();
            try
            {
                var valueTxtBox = _calculator.Eval(left, right);

                txtBoxValue.Text = valueTxtBox.ToString();
                txtScoreboard.Text = string.Empty;
            }
            catch (Exception exception)
            {
                ShowError(exception.Message);
            }
        }

        private void txtScoreboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (txtScoreboard.Text.Contains(',') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}