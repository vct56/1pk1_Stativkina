namespace Task_03_05
{
    internal class Program
    {
        static void Main()
        {
            // Ввод диапазона температур
            Console.WriteLine("Введите начальную температуру в градусах Цельсия: ");
            double startCelsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конечную температуру в градусах Цельсия: ");
            double endCelsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите шаг изменения температуры: ");
            double step = Convert.ToDouble(Console.ReadLine());

            // Вывод заголовка таблицы
            Console.WriteLine("\nТемпература (°C) | Температура (°F)");
            Console.WriteLine("------------------ |------------------");

            // Вывод таблицы
            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius,-18} | {fahrenheit,-18}");
            }
        }
    }
}
