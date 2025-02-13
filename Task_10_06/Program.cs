namespace Task_10_06
{
    internal class Program
    {
        //Создать Метод ArrayGeneration не возвращающий значения,
        //принимает целое число n, выводит наконсольсгенерированный массив размерности n*n
    }

    public class ArrayGenerator
    {
        public static void ArrayGeneration(int n)
        {
            // Проверка на корректность ввода
            if (n <= 0)
            {
                Console.WriteLine("Размер массива должен быть больше 0.");
                return;
            }

            // Создание и заполнение массива случайными числами
            int[,] array = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }


            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j],3}");
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите размерность массива (n): ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                ArrayGeneration(n);
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
    }
}