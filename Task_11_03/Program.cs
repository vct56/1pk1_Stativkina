namespace Task_11_03
{
    internal class Program
    {
        //Выходной параметр (out): Напишите метод,
        //который принимает строки и возвращает через выходной параметр
        //количество гласных и согласных букв в этой строк
         
        static void Main()
        {
            string input = "лоаиркорирууоооКЛилФ";
            CountLetters(input, out int vowelsCount, out int consonantsCount);
            Console.WriteLine($"Гласные: {vowelsCount}, Согласные: {consonantsCount}");
        }

        static void CountLetters(string str, out int vowelsCount, out int consonantsCount)
        {
            vowelsCount = 0;
            consonantsCount = 0;
            string vowels = "аеиоуюэёАЕИОУЮЭЁ";

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                        vowelsCount++;
                    else
                        consonantsCount++;
                }
            }
        }
    }

}

