using System;

namespace lab9
{
    public delegate void Fun();
    class TestMain
    {
        private static void Calc()
        {
            double f(double x) => x / (x - 1);
            Console.Write("Введiть нижню межу = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть верхню межу = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть кiлькiсть вiдрiзкiв, на яку розбивається iнтеграл = ");
            int n = Convert.ToInt16(Console.ReadLine());
            var h = (b - a) / n;
            var sum = 0d;
            for (var i = 1; i <= n; i++)
            {
                var x = a + i * h;
                sum += f(x);
            }

            var result = h * sum;
            Console.WriteLine($"Вiдповiдь: {Math.Round(result, 3)}");
        }
        public static void Main()
        {
            Fun x = new Fun(Calc);
            x();
            Console.WriteLine();
        }
    }