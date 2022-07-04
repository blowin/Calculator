namespace Calculator
{
    public partial class Form1 : Form
    {
        private float _a;
        private char _arithmeticOperation;
        private bool _numberSign = true;

        public Form1()
        {

            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtScoreboard.Text != "0")
                txtScoreboard.Text = txtScoreboard.Text + 0;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = txtScoreboard.Text + 9;
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
            if (_numberSign == true)
            {
                _numberSign = false;
                txtScoreboard.Text = "-" + txtScoreboard.Text;
            }
            else if (_numberSign == false)
            {
                _numberSign = true;
                txtScoreboard.Text = txtScoreboard.Text.Replace("-", "");
            }
        }

        private void txtBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBoxValue.ReadOnly = true;
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;
            if (text.Length > 0 && text.Any(char.IsNumber))
            {
                if (txtBoxValue.Text.Length == 0)
                {
                    _a = float.Parse(text);
                }
                else if (_arithmeticOperation == '-')
                {
                    _a -= float.Parse(text);
                }
                else
                {
                    var b = float.Parse(text);
                    _a = ComputingOperation(_a, b, _arithmeticOperation);
                }

                txtBoxValue.Text = _a.ToString();
                txtScoreboard.Text = string.Empty;
            }
            _arithmeticOperation = '-';
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;
            if (text.Length > 0 && text.Any(char.IsNumber))
            {
                if (txtBoxValue.Text.Length == 0)
                {
                    _a = float.Parse(text);
                }
                else if (_arithmeticOperation == '*')
                {
                    _a *= float.Parse(text);
                }
                else
                {
                    var b = float.Parse(text);
                    _a = ComputingOperation(_a, b, _arithmeticOperation);
                }

                txtBoxValue.Text = _a.ToString();
                txtScoreboard.Text = string.Empty;
            }
            _arithmeticOperation = '*';
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;
            if (text.Length > 0 && text.Any(char.IsNumber))
            {
                if (txtBoxValue.Text.Length == 0)
                {
                    _a = float.Parse(text);
                }
                else if (_arithmeticOperation == '+')
                {
                    _a += float.Parse(text);
                }
                else
                {
                    var b = float.Parse(text);
                    _a = ComputingOperation(_a, b, _arithmeticOperation);
                }

                txtBoxValue.Text = _a.ToString();
                txtScoreboard.Text = string.Empty;
            }
            _arithmeticOperation = '+';
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;
            if (text.Length > 0 && text.Any(char.IsNumber))
            {
                if (txtBoxValue.Text.Length == 0)
                {
                    _a = float.Parse(text);
                }
                else if (_arithmeticOperation == '/')
                {
                    _a /= float.Parse(text);
                }
                else
                {
                    var b = float.Parse(text);
                    _a = ComputingOperation(_a, b, _arithmeticOperation);
                }

                txtBoxValue.Text = _a.ToString();
                txtScoreboard.Text = string.Empty;
            }
            _arithmeticOperation = '/';
        }

        private float ComputingOperation(float a, float b, char operation)
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
                    return a / b;
            }
            return 0;
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;


            if (text.Length > 0 && text.Any(char.IsNumber))
            {

                var b = float.Parse(text);
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