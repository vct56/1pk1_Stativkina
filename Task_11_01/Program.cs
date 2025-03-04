namespace Task_11_01
{
    internal class Program
    {

        //Напишите метод, который принимает два целых числа
        //и меняет их местами.
        
        public class SwapNumbers
        {
            public static void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            public static void Main(string[] args)
            {
                int a = 66;
                int b = 77;

                Console.WriteLine($"до изменения : a = {a}, b = {b}"); // Выведет: до изменения : a = 10, b = 20

                Swap(ref a, ref b); 

                Console.WriteLine($"после измениния : a = {a}, b = {b}"); // Выведет: росле изменения : a = 20, b = 10
            }
        }
    }
}





