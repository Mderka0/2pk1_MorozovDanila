using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_010
{
    class Program
    {
        static void Main(string[] args)
        {

            char[][] Arr = new char[5][];
            char[] Last = new char[5];
            Random rnd = new Random();
            int first_simbol = Convert.ToInt32('a');
            int last_simbol = Convert.ToInt32('z');
            Arr[0] = new char[rnd.Next(5, 16)];
            Arr[1] = new char[rnd.Next(5, 16)];
            Arr[2] = new char[rnd.Next(5, 16)];
            Arr[3] = new char[rnd.Next(5, 16)];
            Arr[4] = new char[rnd.Next(5, 16)];



            for (int y = 0; y < Arr.Length; y++)
            {
                for (int x = 0; x < Arr[y].Length; x++)
                {
                    Arr[y][x] = Convert.ToChar(rnd.Next(first_simbol, last_simbol + 1));
                    Console.Write(" " + Arr[y][x]);
                }
                Console.WriteLine();
            }


            char[] lastVals = new char[Arr.Length];

            for (int i = 0; i < lastVals.Length; i++)
            {
                lastVals[i] = Arr[i][/*у меня не получилось вывести последнее значение с каждой строчки*/];
            }


            Console.WriteLine("Последние элементы каждой строки: ");
            foreach (char ch in lastVals)
            {
                Console.Write($"{ch} ");
            }
            Console.ReadLine();

        }
    }
}
