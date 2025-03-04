namespace Task_11_08
{
    internal class Program
    {
        //Использование params и out: Напишите метод, который принимает переменное количество чисел
        //и возвращает их сумму и максимальное значение через выходные параметры(out).
     
            static void Main(string[] args)
            {
                // Вызов метода с переменным количеством аргументов
                int maxValue;
                int sum = GetSumAndMax(out maxValue, 10, 20, 5, 30, 15);

                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine($"Максимальное значение: {maxValue}");
            }

            static int GetSumAndMax(out int max, params int[] numbers)
            {
                int sum = 0;
                max = int.MinValue;

                foreach (int number in numbers)
                {
                    sum += number;
                    if (number > max)
                    {
                        max = number;
                    }
                }

                return sum;
            }
        }

    }


    
