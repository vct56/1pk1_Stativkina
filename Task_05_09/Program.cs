namespace Task_05_09
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. 
         * Произведите анализ данной матрицы и выясните является ли данная матрица 
         * Z-матрицей(это матрица, где все недиагональные элементы меньше нуля)
         * Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. 
         * Если не выполняется, то вывести сообщение что данная матрица не является Z-матрицей
         */
        static void Main(string[] args)
        {
            {
                Console.Write(" Введите размерность матрицы n ");
                int n = int.Parse(Console.ReadLine());
                int[,] matrix = new int[n, n];
                Random random = new Random();

                // Заполнение матрицы случайными числами от -10 до 10
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = random.Next(-10, 11);
                    }
                }

                // Проверка на Z-матрицу
                bool ZMatrix = true;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j & matrix[i, j] >= 0)
                        {
                           ZMatrix = false;
                           break;
                        }
                    }
                    if (ZMatrix) break;
                }

                // Вывод матрицы
                if (ZMatrix)
                {
                    Console.WriteLine("Матрица является Z-матрицей");
                    for (int i = 0; i < n; i++)
                    {
                       for (int j = 0; j < n; j++)
                       {
                           if (i == j)
                           {
                           Console.BackgroundColor = ConsoleColor.Green; // Цвет для главной диагонали
                           }
                           Console.Write(matrix[i, j] + "\t");
                           Console.ResetColor();
                       }
                       Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Матрица не является Z-матрицей.");
                }
            }
        }
    }
}