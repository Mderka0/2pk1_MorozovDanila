using System;

namespace PZ_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1/Вариант 16/ Диапазон 10..90/ Шаг 3 ");
            int i;
            for (i = 10; i <= 90; i = i + 3) Console.WriteLine(i);
            Console.WriteLine("Задание №2/Вариант 16/ Символ Б/ n 6");
            int n = 6;
            for (i = 1; i <= n; i++) Console.Write("Б"); Console.WriteLine();
            Console.WriteLine("Задание №3/Вариант 16/ n 5/ m 7 ");
            n = 5;
            int m = 7;
            int z;
            for (i = 1; i <= m; i++)
            {
                for (z = 1; z <= n; z++) Console.Write("#"); Console.WriteLine();
            }
            Console.WriteLine("Задание №4/Вариант 16/ значение 8 ");
            for (i = 0; i <= 100; i = i + 8)
            {
                if (i % 8 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Задание №5/Вариант 16/ i 3/ j 60/ Разница 13");
            int j;
            for (i = 3, j = 50; j - i == 13; i++, j--)
            {
                Console.WriteLine($"{i}{j}");
            }
        }
    }
}
