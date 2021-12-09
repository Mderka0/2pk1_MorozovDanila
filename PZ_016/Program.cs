using System;

namespace PZ_16
{
    class Program
    {
        static void InvertDigits(ref int K)
        {
            int reverse = 0;
            while (K != 0)
            {
                reverse *= 10;
                reverse += K % 10;
                K /= 10;
            }
            K = reverse;
        }

        static void Main(string[] args)
        {
            int K = Convert.ToInt32(Console.ReadLine());
            InvertDigits(ref K);
            Console.WriteLine(K);
            Console.ReadLine();
        }
        
    }
}
