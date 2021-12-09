using System;
using System.Linq;

namespace pz_18
{
    class Program
    {
        //Задание 1
        static int z1(double a1, double d, double n1)
        {

            if (n1 < 0)
            {
                Console.WriteLine("Ошибка");
                return 0;
            }
            if (n1 == 0)
            {
                Console.WriteLine(a1);
                return (int)a1;
            }
            else
            {
                a1 = a1 + d;
                n1 = n1 - 1;
                return z1(a1, d, n1);
            }

        }
        //Задание 2
        static double z2(int b1, int q, int n2)
        {
            if (n2 < 0)
            {
                Console.WriteLine("Ошибка");
                return 0;
            }
            if (n2 == 0)
            {
                Console.WriteLine(b1);
                return b1;
            }
            else
            {
                b1 = b1 * q;
                n2 = n2 - 1;
                return z2(b1, q, n2);
            }

        }
        //Задание 3
        static int z3(int A, int B)
        {
            if (A == B)
            {
                Console.WriteLine($"{A}\n");
                return 0;
            }
            else
            {
                Console.Write($"{A} ");
                A += 1;
            }
            return z3(A, B);
        }
        //Задание 4
        static int Summ(int x, int n4)
        {
            if (x < 0) {
                Console.WriteLine("Ошибка!");
                return 0; 
            }
            if (x == 0) {
                Console.WriteLine(0);
                return 0; 
            }
            if (x == 1) {
                Console.WriteLine($"Сумма чисел = {n4 + 1 } ");
            }
            else {
                n4 = n4 + x;
                x = x - 1;
                return Summ(x, n4);
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Задание №1:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            z1(7, -0.1, n1);
            Console.Write("Задание №2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            z2(13, 3, n2);
            Console.Write("задание №3:");
            z3(8, 65);
            Console.Write("задание №4:");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Summ(n4, 0);
            Console.ReadLine();
        }
    }
}