using System;

namespace PZ_012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дан текст в котором есть часы, минуты и секунды.");
            Console.Write("Введите время по Гринвичу: ");
            string time = Console.ReadLine();
            char[] sep = { ' ', ',', '.', ':' };
            string[] timeParts = time.Split(sep);
            int hours = Convert.ToInt32(timeParts[0]) + 5;
            if (hours > 23)
            {
                hours -= 24;
            }
            Console.WriteLine($"Время по GTM+5: {hours}:{timeParts[1]}:{timeParts[2]}");
        }
    }
}
