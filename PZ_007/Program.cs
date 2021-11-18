using System;

namespace PZ_008
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(0, 50);
            }
            int[] fir = new int[5];
            int[] sec = new int[5];
            int[] fin = new int[10];
            Array.Copy(array, 0, fir, 0, 5);
            Array.Copy(array, 5, sec, 0, 5);
            Array.Sort(fir);
            Array.Sort(sec);
            Array.Reverse(sec);
            Array.Copy(fir, 0, fin, 0, 5);
            Array.Copy(sec, 0, fin, 5, 5);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(fin[i]);
            }
        }
    }
}
