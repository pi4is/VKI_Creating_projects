using System;

namespace CreatingProjec
{
    public class FunctionCalculator
    {
        public static void CalculateFunction(double N, int k)
        {
            double step = 0.1;

            for (double x = 0; x < k; x += step)
            {
                try
                {
                    if (Math.Abs(x -N) < 1e-10) { throw new DivideByZeroException(); } //данное необходимо, чтоб отловить 0

                    double result = 1 / (x - N);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Ошибка: деление на 0 при x = {x}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Ошибка: выход за пределы диапазона при x = {x}");
                }
                finally
                {
                    Console.WriteLine($"f({x}) = {1 / (x - N)}");
                }
            }
        }
    }
}
