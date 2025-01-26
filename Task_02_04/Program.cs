namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Запрашиваем у пользователя год рождения
            Console.WriteLine("Введите год рождения:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день рождения:");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);
            DateTime thisday = DateTime.Now;

            int age = thisday.Year - birthday.Year;

            if (birthday.Month < thisday.Month)
                age--;
            else if (birthday.Month == thisday.Month)
                if (birthday.Day > thisday.Day)
                    age--;
            if (age >= 18)
                Console.WriteLine("Пользователь совершеннолетний");
            else
                Console.WriteLine("Пользователь несовершеннолетний");
        }
    }
}
