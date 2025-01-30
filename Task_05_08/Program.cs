namespace Task_05_08
{
    using static System.Runtime.InteropServices.JavaScript.JSType;

    namespace Task_05_08
    {
        internal class Program
        {
            /*Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. 
             * Создать новый массив, который будет произведением двух предыдущих 
             * (перемножить элементы первых двух массивов, стоящие на одинаковых позициях 
             * и записать их в результирующий массив) 
             * Вывести результирующий массив
             */

            static void Main()
            {
                int n = 10;
                int[,] number1 = new int[n, n];
                int[,] number2 = new int[n, n];
                int[,] result = new int[n, n];

                Random random = new Random();

                // Заполнение первого массива
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        number1[i, j] = random.Next(1, 10);
                    }
                }

                // Заполнение второго массива
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        number2[i, j] = random.Next(1, 10);
                    }
                }

                // Перемножение массивов
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[i, j] = number1[i, j] * number2[i, j];
                    }
                }

                // Вывод результирующего массива
                Console.WriteLine("Результирующий массив:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(result[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
