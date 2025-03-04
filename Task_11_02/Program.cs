namespace Task_11_02
{
    internal class Program
    {
        //Передача по ссылке (ref): Напишите метод,
        //который принимает два целых числа по ссылке
        //и меняет их местами.Проверьте,
        //изменились ли значения переменных вне метода



        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Перед вызовом метода: a = {a}, b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"После вызова метода: a = {a}, b = {b}");
        }
    }
    
}
