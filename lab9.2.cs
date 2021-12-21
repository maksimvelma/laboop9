using System;

namespace _92
{
    public delegate void Fun(double a, double b, int n);
    class TestMain
    {
        private static void Calc(double a, double b, int n)
        {
            double f(double x) => x / (x - 1);
            var h = (b - a) / n;
            var sum = 0d;
            for (var i = 1; i <= n; i++)
            {
                var x = a + i * h;
                sum += f(x);
            }

            var res = h * sum;
            Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
        }
        private static void Input(double a, double b, int n)
        {
            Console.WriteLine($"Введенi значення: [{a}, {b}, {n}]");
        }
        public static void Main()
        {
            Fun x = new Fun(Input);
            Fun y = new Fun(Calc);
            x += y;
            x(2.15, 4.99, 3);
            x += x;
            x(0.5, 3, 4);
            x -= y; x -= y; x -= y;
            x(1.25, 4.8, 7);
            Console.WriteLine();
        }
    }
}