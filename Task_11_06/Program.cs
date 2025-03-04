namespace Task_11_06
{
    internal class Program
    {
        // Передача массива по значению: Напишите метод,
        // который принимает массив целых чисел и изменяет его элементы,
        // увеличивая каждый на 1. Проверьте, изменился ли оригинальный массив вне метода.

        public static void IncrementArrayCopy(int[] arr)
        {
            int[] copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length); // Создаем копию

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i]++;
            }

            arr = copy;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Оригинальный массив:");
            PrintArray(numbers);

            IncrementArrayCopy(numbers);

            Console.WriteLine("\nМассив после вызова метода:");
            PrintArray(numbers);
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }

}
   