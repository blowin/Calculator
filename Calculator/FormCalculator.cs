namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private bool _numberSign = true;
        private MathEvaluator _mathhEvaluator;

        public FormCalculator()
        {
            InitializeComponent();
            _mathhEvaluator = new MathEvaluator();
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
            _mathhEvaluator = new MathEvaluator();
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

        private void btnArithmeticOperation_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;
            var textValue = txtBoxValue.Text;
            var operation = char.Parse(((Button)sender).Text);

            _mathhEvaluator.Math(operation);
            var valueTxtBox = _mathhEvaluator.Eval(textValue, text);

            txtBoxValue.Text = valueTxtBox.ToString();
            txtScoreboard.Text = string.Empty;
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            var text = txtScoreboard.Text;
            var textValue = txtBoxValue.Text;
            var operation = char.Parse(((Button)sender).Text);

            _mathhEvaluator.Math(operation);
            var valueTxtBox = _mathhEvaluator.GetResult(textValue, text);

            txtBoxValue.Text = valueTxtBox.ToString();
            txtScoreboard.Text = string.Empty;
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