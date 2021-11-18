using System;

namespace PZ_009
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[10, 10];
            Random rnd = new Random();
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    a[i, j] = rnd.Next(100);
                    Console.Write("{0,4}", a[i, j]);

                }
            }
            int sum = 0;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    sum += a[j, i];
                }
                Console.WriteLine();
                Console.WriteLine("Сумма " + (i + 1) + " столбца равна " + sum);
                sum = 0;
            }

        }
    }
}
