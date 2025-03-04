namespace Task_11_07
{
    internal class Program
    {
        //Передача массива по ссылке (ref):
        //Напишите метод, который принимает массив целых чисел по ссылке и изменяет его элементы,
        //увеличивая каждый на 1. Проверьте, изменился ли оригинальный массив вне метода.

        public static void Increment(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++; 
            }
        }

        public static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4,};

            Console.WriteLine("Оригинальный массив:");
            PrintArray(myArray); // Вывод оригинального массива

            Increment(ref myArray); // Вызов метода с передачей по ссылке

            Console.WriteLine("\nМассив после IncrementElements:");
            PrintArray(myArray); 
        }

        static void PrintArray(int[] arr)
        {
            foreach (var a in arr)
            {
                Console.Write($"{a} "); 
            }
            Console.WriteLine(); 
        }
    }

}
  
