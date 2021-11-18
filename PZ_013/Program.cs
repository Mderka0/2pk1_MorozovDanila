using System;

namespace PZ_013
{
    class Program
    {
        enum Marks
        {
            one = 1,
            two,
            three,
            four,
            five
        }
        static void Main(string[] args)
        {
            Console.Write("Введите отметку [one, two, three, four, five]: ");
            string mark = Console.ReadLine();
            Marks m;

            Enum.TryParse(mark, out m);

            switch (m)
            {
                case Marks.one:
                    Console.WriteLine($"Характеристика отметки {mark}: МЕГАплохо");
                    break;
                case Marks.two:
                    Console.WriteLine($"Характеристика отметки {mark}: плохо");
                    break;
                case Marks.three:
                    Console.WriteLine($"Характеристика отметки {mark}: нормально");
                    break;
                case Marks.four:
                    Console.WriteLine($"Характеристика отметки {mark}: хорошо");
                    break;
                case Marks.five:
                    Console.WriteLine($"Характеристика отметки {mark}: отлично");
                    break;
                default:
                    Console.WriteLine("Некорректное значение");
                    break;
            }
        }
    }
}
