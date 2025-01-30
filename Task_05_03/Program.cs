namespace Task_05_03
{

    internal class Program
    {


        static void Main()
        {
            char[,] matrix1 = {
            { 'A', 'B', 'C' },
            { 'D', 'E', 'F' },
            { 'I', 'H', 'I' }
        };

            char[,] matrix2 = {
            { 'A', 'X', 'C' },
            { 'D', 'Y', 'F' },
            { 'G', 'H', 'Z' }
        };

            if (AreMatricesEqual(matrix1, matrix2))
            {
                Console.WriteLine("Матрицы равны.");
            }
            else
            {
                Console.WriteLine("Матрицы не равны. Равные элементы выделены:");
                PrintMatricesWithHighlight(matrix1, matrix2);
            }
        }

        static bool AreMatricesEqual(char[,] matrix1, char[,] matrix2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void PrintMatricesWithHighlight(char[,] matrix1, char[,] matrix2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        Console.BackgroundColor = ConsoleColor.Green; // Цвет для равных элементов
                        Console.Write(matrix1[i, j] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(matrix1[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.ResetColor(); // Сброс цвета
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        Console.BackgroundColor = ConsoleColor.Green; ; // Цвет для равных элементов
                        Console.Write(matrix2[i, j] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(matrix2[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}

