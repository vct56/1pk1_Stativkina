namespace Task_05_04
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. 
         * Произведите анализ данной матрицы и выясните является ли данная матрица диагональной 
         (все элементы вне главной диагонали равны нулю)
         Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. 
         Если нет, то вывеси сообщение что матрица не является диагональной.
         */



        static void Main()
        {
            // Ввод размерности матрицы
            Console.Write("Введите размерность матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            // Создание и заполнение матрицы
            int[,] matrix = new int[n, n];
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Проверка на диагональность
            bool isDiagonal = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        isDiagonal = false;
                        break;
                    }
                }
                if (!isDiagonal) break;
            }

            // Вывод результата
            if (isDiagonal)
            {
                Console.WriteLine("Матрица является диагональной:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // Цвет выделения
                            Console.Write(matrix[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }
        }
    }
}