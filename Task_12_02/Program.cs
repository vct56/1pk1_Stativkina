namespace Task_12_02
{
   
        internal class Program
        {
        //создайте проект с классом Cat и Dog, полностью самостоятельно продумайте данные для объектов класса и их функционал
        static void Main(string[] args)
            {
                Cat cat1 = new Cat { Name = "Шлёпа", Age = 2, Weight = 4.5, Breed = "Британец" };
                Dog dog1 = new Dog { Name = "Жора", Age = 3, Weight = 3.0, Breed = "Шпиц " };

                cat1.GetInfo(); 
                dog1.GetInfo(); 

                
            }
        }

        class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Weight { get; set; }
            public string Breed { get; set; }

            public void GetInfo()
            {
                Console.WriteLine($"{Name}, {Age} года, {Weight} кг, порода: {Breed}");
            }

            
        }

        class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Weight { get; set; }
            public string Breed { get; set; }

            public void GetInfo()
            {
                Console.WriteLine($"{Name}, {Age} года, {Weight} кг, порода: {Breed}");
            }

            
       }

          
}
        
 
