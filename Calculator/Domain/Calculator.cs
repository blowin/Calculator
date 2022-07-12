namespace Calculator.Domain
{
    public class Calculator
    {
        private static readonly char[] ArithmeticOperation = new char[] { '+', '-', '*', '/', '=' };

        private char? _pastOperation;

        public IDigit Eval(IDigit x, IDigit y, char operation)
        {
            if (!ArithmeticOperation.Contains(operation))
                throw new ArgumentException("Неверная арифметическая операция");
            
            if (x.Value == 0)
                return y;
            
            _pastOperation = operation;
            return EvalCore(x, y, operation);
        }
        
        public IDigit Eval(IDigit x, IDigit y)
        {
            if (_pastOperation == null)
                return DecimalDigit.Zero;

            var ret = EvalCore(x, y, _pastOperation.Value);
            return _pastOperation switch
            {
                null => DecimalDigit.Zero,
                '=' => y,
                _ => ret
            };
        }

        private static IDigit EvalCore(IDigit x, IDigit y, char operation)
        {
            switch (operation)
            {
                case '+':
                    return new DecimalDigit(x.Value + y.Value);
                case '-':
                    return new DecimalDigit(x.Value - y.Value);
                case '*':
                    return new DecimalDigit(x.Value * y.Value);
                case '/':
                {
                    if (y.Value == 0)
                        throw new ArgumentException("Деление на 0 невозможно");
                    return new DecimalDigit(x.Value / y.Value);
                }
            }

            throw new OperationCanceledException($"Неизвестный оператор {operation}");
        }
    }
}
