namespace Task_11_05
{
    internal class Program
    {
        //Комбинирование ref и out: Напишите метод,
        //который принимает два числа по ссылке (ref) и
        //возвращает их сумму и произведение через выходные параметры(out).

        static void Main()
        {
            int a = 5;
            int b = 4;

            int sum;
            int product;

            // Вызов метода
            Calculate(ref a, ref b, out sum, out product);
            // Вывод результатов
            Console.WriteLine($"Сумма: {sum}, Произведение: {product}");
        }

        static void Calculate(ref int a, ref int b, out int sum, out int product)
        {
            sum = a + b;         // Вычисляем сумму
            product = a * b;    // Вычисляем произведение
        }
    }
}
