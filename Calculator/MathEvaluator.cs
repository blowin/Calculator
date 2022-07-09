namespace Calculator
{
    public class MathEvaluator
    {
        private readonly static char[] _arithmeticOperation = new char[] { '+', '-', '*', '/', '=' };
        private char _pastOperation;
        private char _operation;
        private decimal _a;
        private decimal _pastValue;

        public void Math(char operation)
        {
            if (!_arithmeticOperation.Any(x => x == operation))
                throw new ArgumentException("Неверная арифметическая операция");
            _operation = operation;
        }

        public decimal Eval(string x, string y)
        {
            if (decimal.TryParse(x, out var firstValue))
                _a = firstValue;

            if (decimal.TryParse(y, out var value))
            {
                if (x.Length == 0)
                {
                    _a = value;
                }
                else
                {
                    if (_operation == '=')
                    {
                        _a = ComputingOperation(_a, value, _operation);
                    }
                    else
                    {
                        _a = ComputingOperation(_a, value, _pastOperation);
                    }
                }
            }
            else if (x.Length == 0)
                throw new ArgumentException("Неправильная числовая строка");

            _pastOperation = _operation;
            return _a;
        }

        public decimal GetResult(string x, string y)
        {
            if (decimal.TryParse(x, out var firstValue))
                _a = firstValue;

            if (decimal.TryParse(y, out var value))
            {
                if (_pastOperation == '=')
                {
                    _a = value;
                }
                else
                {
                    _a = ComputingOperation(_a, value, _pastOperation);
                    _pastValue = value;
                }
            }
            else if (y.Length == 0)
            {
                if (_pastValue == 0)
                    _pastValue = _a;
                _a = ComputingOperation(_a, _pastValue, _pastOperation);
            }
            else if (x.Length == 0)
                throw new ArgumentException("Неправильная числовая строка");

            return _a;
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
    }
}
