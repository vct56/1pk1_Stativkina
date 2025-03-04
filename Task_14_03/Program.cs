namespace Task_14_03
{
    internal class Program
    {
        public static long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Число должно быть неотрицательным.");
            }

            if (number == 0) return 1;

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Введите неотрицательное целое число: ");
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                try
                {
                    long factorial = Factorial(input);
                    Console.WriteLine($"Факториал {input} = {factorial}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
    }

}
