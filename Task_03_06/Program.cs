namespace Task_03_06
{
    internal class Program
    {
          static void Main(string[] args)
            {
                double startX = -4.0;
                double endX = 4.0;
                double step = 0.5;

                // Выводим заголовок таблицы
                Console.WriteLine("Таблица значений функции y = |x|");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("x\t|\ty");
                Console.WriteLine("-----------------------------------");

                // Вычисляем и выводим значения функции
                for (double x = startX; x <= endX; x += step)
                {
                    double y = Math.Abs(x);
                    Console.WriteLine($"{x}\t|\t{y}");
                }

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Нажмите любую клавишу для выхода.");
                Console.ReadKey();
            }
        }
    }