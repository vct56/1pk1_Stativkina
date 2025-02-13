namespace Task_10_07
{
    internal class Program
    {
        //Создайте метод с помощью которого можно сгенерировать
        //и вернуть символьный двумерныймассив(состоящийиз символов русского алфавита)
        //и выведите на консоль данный массив с помощью другого метода
        //(который принимает данный массив в качестве параметра)
      
       public class CharArrayGenerator
        {
            // Метод для генерации двумерного массива символов русского алфавита
            public static char[,] GenerateCharArray(int rows, int cols)
            {
 
                string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                char[,] charArray = new char[rows, cols];
                Random random = new Random();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        charArray[i, j] = alphabet[random.Next(alphabet.Length)];
                    }
                }

                return charArray;
            }

          
            public static void PrintCharArray(char[,] array)
            {
                if (array == null) return; // Проверка на null

                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            public static void Main(string[] args)
            {
                Console.Write("Введите количество строк: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                int cols = int.Parse(Console.ReadLine());

                char[,] charArray = GenerateCharArray(rows, cols);
                PrintCharArray(charArray);
            }
        }
    }
    }

