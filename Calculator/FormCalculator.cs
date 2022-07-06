namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private decimal _a;
        private char _arithmeticOperation;
        private bool _numberSign = true;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtScoreboard.Text == "0")
                txtScoreboard.Text = string.Empty;
            txtScoreboard.Text = txtScoreboard.Text + (sender as Button).Text;
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var lenght = txtScoreboard.Text.Length;
            if (lenght != 0)
                txtScoreboard.Text = txtScoreboard.Text.Remove(lenght - 1);
        }

        private void btnNumberSign_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = _numberSign ? "-" + txtScoreboard.Text : txtScoreboard.Text.Replace("-", ""); _numberSign = !_numberSign;
        }


        private void btnOperation_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;
            var operation = char.Parse((sender as Button).Text);
            if (decimal.TryParse(text, out var value))
            {
                if (txtBoxValue.Text.Length == 0)
                {
                    _a = value;
                }
                else
                {
                    var b = value;
                    if (_arithmeticOperation == '=')
                    {
                        _a = ComputingOperation(_a, b, operation);
                    }
                    else
                    {
                        _a = ComputingOperation(_a, b, _arithmeticOperation);
                    }

                }

                txtBoxValue.Text = _a.ToString();
                txtScoreboard.Text = string.Empty;
            }
            _arithmeticOperation = operation;
        }

        private decimal ComputingOperation(decimal a, decimal b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    {
                        if (b == 0)
                            throw new ArgumentException("Деление на 0 невозможно");
                        return a / b;
                    }
            }
            throw new OperationCanceledException("Не верное нажатие кнопки");
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;


            if (decimal.TryParse(text, out var b))
            {
                if (_arithmeticOperation == '=')
                {
                    _a = b;
                }
                else
                {
                    _a = ComputingOperation(_a, b, _arithmeticOperation);
                }
            }
            else
            {
                _a = 0;
            }
            txtBoxValue.Text = _a.ToString();
            txtScoreboard.Text = string.Empty;
            _arithmeticOperation = '=';
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