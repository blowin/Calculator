namespace Calculator
{
    public class MathEvaluator
    {
        public static decimal Eval(decimal a, decimal b, char operation)
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
