namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

                //Количество строк
                int lines = 0;

                while (true)
                {
                    //Ввод текста
                    Console.WriteLine("Введите текст:");
                    string text = Console.ReadLine();

                    lines++;

                    //В случае ввода пустой строки или exit
                    if (string.IsNullOrEmpty(text) || text.Equals("exit"))
                    {
                        //очищаем консоль 
                        Console.Clear();

                        Console.WriteLine($"Кол-во введенных строк: " + lines);
                        break;
                    }
                }
            }
        }
    }
}