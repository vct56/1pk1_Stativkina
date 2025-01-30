namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
        • 1 столбец содержит нули
        • 2 столбце содержит числа кратные 2
        • 3 столбец содержит числа кратные 3
        • 4 столбец содержит числа кратные 4
        • 5 столбец содержит числа кратные 5
        Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив
        */

        static void Main()
        {
            int[,] nomber = new int[10, 5];

            // Заполнение массива по заданным правилам
            for (int i = 0; i < 10; i++)
            {
                nomber[i, 0] = 0; // 1 столбец содержит нули
                nomber[i, 1] = i * 2; // 2 столбец содержит числа кратные 2
                nomber[i, 2] = i * 3; // 3 столбец содержит числа кратные 3
                nomber[i, 3] = i * 4; // 4 столбец содержит числа кратные 4
                nomber[i, 3] = i * 4; // 4 столбец содержит числа кратные 4
                nomber[i, 4] = i * 5; // 5 столбец содержит числа кратные 5
            }

            // Вывод исходного массива
            Console.WriteLine("Исходный массив:");
            PrintArray(nomber);

            // Транспонирование массива
            int[,] transposedArray = TransposeArray(nomber);

            // Вывод обновленного массива
            Console.WriteLine("Транспонированный массив:");
            PrintArray(transposedArray);
        }

        static void PrintArray(int[,] nomber)
        {
            for (int i = 0; i < nomber.GetLength(0); i++)
            {
                for (int j = 0; j < nomber.GetLength(1); j++)
                {
                    Console.Write(nomber[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] TransposeArray(int[,] nomber)
        {
            int rows = nomber.GetLength(0);
            int cols = nomber.GetLength(1);
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = nomber[i, j];
                }
            }

            return transposed;
        }
    }
}

        





        