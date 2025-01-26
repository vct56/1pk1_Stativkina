using System.IO;
namespace Task_02_02
{
    internal class Program
    {
        /* Найти значение выражения 
         * при a=8, b=14, c=π/4
         */

        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double part1 = Math.Pow(b + Math.Pow(a - 1, 1.0 / 3.0), 1.0 / 4.0);
            double part2 = Math.Abs(a - b) * (Math.Sin(c) * (Math.Sin(c) + Math.Tan(c)));
            double result = part1 / part2;

            Console.WriteLine(Math.Round(result, 2));

            Console.WriteLine(Math.E);
        }
    }
}