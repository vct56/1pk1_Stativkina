namespace Task_03_07
{
    internal class Program
    {
   
       static void Main(string[] args)
          {
                double g = 9.8; // Ускорение свободного падения в m/s^2
                double startTime = 0.0; // Начальное время в секундах
                double endTime = 5.0; // Конечное время в секундах
                double step = 0.5; // Шаг изменения времени в секундах

                // Выводим заголовок таблицы
                Console.WriteLine("Таблица скорости свободно падающего тела");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Время (с)\t|\tСкорость (м/с)");
                Console.WriteLine("-----------------------------------------");

                // Вычисляем и выводим значения скорости
                for (double t = startTime; t <= endTime; t += step)
                {
                    double velocity = g * t;
                    Console.WriteLine($"{t}\t\t|\t{velocity:F2}");
                }

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Нажмите любую клавишу для выхода.");
                Console.ReadKey();
            }
        }
}
