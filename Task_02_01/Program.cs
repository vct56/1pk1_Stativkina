namespace Task_02_01
{
    internal class Program
    {
        /*пользователь вводит два действительных числа.
         * программа должна подсчитать сумму ,произведение,
         * разность и деление этих чисел и вывести результат 
         * в консоль .
         */
        
        static void Main(string[] args)
        {
            //ввод данных 
            Console.WriteLine(" введите первое число (a)");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" введите второ число (b)");
            double b = Convert.ToDouble(Console.ReadLine());

            //вычисление и вывод результата
            double summAB = a + b;
            Console.WriteLine("сумма чисел: " + summAB);

            double multipleAB = a * b;
            Console.WriteLine(" произведение чисел :" + multipleAB);
            double divAB = a - b;

            Console.WriteLine("разность чисел: " + diffAB);
            double divAB;
            if (b!=0)
            {
                divAB = a / b;
                Console.WriteLine("деление a на b : " + divAB);
            }
            else
            {
                Console.WriteLine("деление на 0 ");
            }
        }
    }
}
