namespace Task_13_02
{
        internal class Program
        {
        //создать класс питомц свойства:кличка, вид животного,
        //возраст, вес, отметка о состонии здоровья(здоров/нездоров)
        //методы:вывод информации об объектеизменение значения веса животного
        //изменение отметки о состоянии здоровья конструторы:предусмотрите разные варианты инициализации объектов
            static void Main(string[] args)
            {
                Pet pet1 = new Pet("Мяукалка", "Кошка", 2, 3.5, true);
                Pet pet2 = new Pet("Жорик", "Собака", 3, 12.0);
                Pet pet3 = new Pet();

                pet1.DisplayInfo();
                pet2.DisplayInfo(); 
                pet3.DisplayInfo(); 

                pet1.ChangeWeight(5.0); // Изменение веса
                pet1.ChangeHealthStatus(false); // Изменение состояния здоровья

                pet1.DisplayInfo(); // Мурзик, Кошка, 2 года, 5.0 кг, состояние: Нездоров
            }
        }

        class Pet
        {
            public string Name { get; set; }
            public string Species { get; set; }
            public int Age { get; set; }
            public double Weight { get; set; }
            public bool IsHealthy { get; set; }

            // Конструктор с параметрами
            public Pet(string name, string species, int age, double weight, bool isHealthy)
            {
                Name = name;
                Species = species;
                Age = age;
                Weight = weight;
                IsHealthy = isHealthy;
            }

            
            public Pet(string name, string species, int age, double weight) : this(name, species, age, weight, true)
            {
            }

            // Конструктор без параметров
            public Pet()
            {
                Name = string.Empty;
                Species = string.Empty;
                Age = 0;
                Weight = 0;
                IsHealthy = false; // По умолчанию нездоров
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"{Name}, {Species}, {Age} года, {Weight} кг, состояние: {(IsHealthy ? "Здоров" : "Нездоров")}");
            }

            public void ChangeWeight(double newWeight)
            {
                Weight = newWeight;
                Console.WriteLine($"Вес {Name} изменен на {Weight} кг");
            }

            public void ChangeHealthStatus(bool healthStatus)
            {
                IsHealthy = healthStatus;
                Console.WriteLine($"Состояние здоровья {Name} изменено");
            }
        }
    }


