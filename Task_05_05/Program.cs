namespace Task_05_05
{
    internal class Program
    {
        /* У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m].
         * Заполнение случайными числами в диапазоне от -99 до 99 включительно.
         * Осуществите без создания нового массива преобразование текущего по следующему правилу:
         • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
         • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
         */
    
        static void Main()
        {
            // Запрос у пользователя размеров массива
            Console.Write("Введите количество строк (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов (m): ");
            int m = int.Parse(Console.ReadLine());


            int[,] numbers = new int[n, m];
            Random random = new Random();

            // Заполнение массива случайными числами от -99 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    numbers[i, j] = random.Next(-99, 100);
                }
            }

            // Преобразование массива и вывод с цветовым выделением
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (numbers[i, j] < 0)
                    {
                        // Отбрасываем знак и выделяем зеленым цветом
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(numbers[i, j]) + " ");
                        Console.ResetColor();
                    }
                    else if (numbers[i, j] == 0)
                    {
                        // Перезаписываем единицу и выделяем красным цветом
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(1 + " ");
                        Console.ResetColor();
                    }
                    else
                    {

                        Console.Write(numbers[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
   

