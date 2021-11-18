using System;

namespace PZ_006
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double x = -2;
            while (-2 <= x && x <= 12)
            {
                if (x < 0)
                {
                    y = x;
                    Console.WriteLine(y);
                }
                else if (0 <= x && x < 10)
                {
                    y = Math.Pow(x, 2);
                    Console.WriteLine(y);
                }
                else
                {
                    y = 2 * x;
                    Console.WriteLine(y);
                }
                x = x + 2;
            }
        }
    }
}
