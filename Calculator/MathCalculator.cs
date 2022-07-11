namespace Calculator
{
    public class MathCalculator
    {
        private readonly static char[] ArithmeticOperation = new char[] { '+', '-', '*', '/', '=' };
        private char _pastOperation;
        private decimal _valueResult;
        private decimal _valueOperand;

        public decimal ArithmeticAction(string x, string y, char operation)
        {
            if (!ArithmeticOperation.Any(x => x == operation))
                throw new ArgumentException("Неверная арифметическая операция");

            if (decimal.TryParse(x, out var firstValue))
                _valueResult = firstValue;

            if (decimal.TryParse(y, out var value))
            {
                if (x.Length == 0)
                {
                    _valueResult = value;
                }
                else
                {
                    if (operation == '=')
                    {
                        _valueResult = MathEvaluator.Eval(_valueResult, value, operation);
                    }
                    else
                    {
                        _valueResult = MathEvaluator.Eval(_valueResult, value, _pastOperation);
                    }
                }
            }
            else if (x.Length == 0)
                throw new ArgumentException("Неправильная числовая строка");

            _pastOperation = operation;
            return _valueResult;
        }

        public decimal CountResult(string x, string y)
        {
            if (decimal.TryParse(x, out var firstValue))
                _valueResult = firstValue;

            if (decimal.TryParse(y, out var value))
            {
                if (_pastOperation == '=')
                {
                    _valueResult = value;
                }
                else
                {
                    _valueResult = MathEvaluator.Eval(_valueResult, value, _pastOperation);
                    _valueOperand = value;
                }
            }
            else if (y.Length == 0)
            {
                if (_valueOperand == 0)
                    _valueOperand = _valueResult;
                _valueResult = MathEvaluator.Eval(_valueResult, _valueOperand, _pastOperation);
            }
            else if (x.Length == 0)
                throw new ArgumentException("Неправильная числовая строка");

            return _valueResult;
        }
    }
}
