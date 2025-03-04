namespace Task_11_04
{
    internal class Program
    {
        // Массив параметров (params): Напишите метод с комментариями ,
        // который принимает массив чисел и возвращает их среднее значение.
        // Используйте ключевое слово params
        static void Main()
        {
           
            double average = CalculateAverage(1, 2, 8, 4, 5);
            Console.WriteLine($"Среднее значение: {average}");
        }

        // Метод принимает массив чисел с использованием params
        static double CalculateAverage(params int[] numbers)
        {
            // Проверяем, есть ли числа для расчета
            if (numbers.Length == 0)
                throw new ArgumentException("Массив чисел не должен быть пустым.");
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Возвращаем среднее значение
            return (double)sum / numbers.Length;
        }
    }

}
  
