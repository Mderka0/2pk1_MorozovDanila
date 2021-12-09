using System;

namespace PZ_17
{
    class Program
    {
        static int Fac(int n)
        {
            int res = 1;
            if (n == 0)
                return 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fac(n));
        }
    }
}
