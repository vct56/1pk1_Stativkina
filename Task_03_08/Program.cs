namespace Task_03_08
{
    internal class Program
    {
        
            static void Main(string[] args)
        {
            Console.WriteLine("Числа от 20 до 50, которые делятся на 3, но не делятся на 5:");

            for (int number = 20; number <= 50; number++)
            {
                if (number % 3 == 0 && number % 5 != 0)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}

                 