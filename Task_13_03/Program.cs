namespace Task_13_03
{
    internal class Program
    {
       static void Main(string[] args)
         {
                // Примеры использования класса Car с различными конструкторами
                Car car1 = new Car(); 
                car1.CarNumber = "A123BC";
                car1.Make = "Toyota";
                car1.Color = "Red";
                Console.WriteLine(car1); 

                Car car2 = new Car("B456CD", "BMW", "Blue"); // Использование конструктора с параметрами
                Console.WriteLine(car2);
                car2.Drive(10, 5); // Ускорение на 10 м/с² в течение 5 секунд
                car2.Brake();      //Торможение
                Console.WriteLine(car2);

                Car car3 = new Car("C389DE", "Mercedes", "Black", 220); //максимальная скорость задаётся в конструкторе
                Console.WriteLine(car3);
                car3.Drive(20, 10);
                car3.Brake();
                Console.WriteLine(car3);


            }
        }

        public class Car
        {
            public string CarNumber { get; set; }
            public string Make { get; set; }
            public string Color { get; set; }
            public int CurrentSpeed { get; private set; } = 0; // Текущая скорость.  private setter для управления через методы
            private int maxSpeed = 200; //максимальная скорость

           
            public Car() { } 

            public Car(string carNumber, string make, string color)
            {
                CarNumber = carNumber;
                Make = make;
                Color = color;
            }

            public Car(string carNumber, string make, string color, int maxSpeed) : this(carNumber, make, color)
            {
                this.maxSpeed = maxSpeed;
            }

            // Методы
            public void Drive(int acceleration, int time)
            {
                int speedIncrease = acceleration * time;
                CurrentSpeed = Math.Min(CurrentSpeed + speedIncrease, maxSpeed); //Не превышает максимальную скорость
                Console.WriteLine($"Автомобиль {Make} ({CarNumber}) едет со скоростью {CurrentSpeed} км/ч.");
            }

            public void Brake()
            {
                if (CurrentSpeed > 0)
                {
                    CurrentSpeed = 0;
                    Console.WriteLine($"Автомобиль {Make} ({CarNumber}) затормозил. Остановился.");
                }
                else
                {
                    Console.WriteLine($"Автомобиль {Make} ({CarNumber}) уже стоит.");
                }
            }

            public override string ToString()
            {
                return $"Номер: {CarNumber}, Марка: {Make}, Цвет: {Color}, Скорость: {CurrentSpeed} км/ч";
            }
        }

    }



