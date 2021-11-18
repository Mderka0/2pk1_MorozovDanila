using System;
using System.IO;

namespace PZ_014
{
    class Program
    {
        static void Main(string[] args)
        {
            string wr_file = Console.ReadLine();
            string dir = @"C:\test_m\";
            string file = $"{wr_file}.txt";
            string FullName = dir + file;

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(FullName))
                File.Create(FullName).Close();

            FileStream file_stream = new FileStream(FullName, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file_stream);

            string[] str = new string[1];
            string[] res = new string[1];
            res[1] = Console.ReadLine();
            int i = 1;

            while (true)
            {
                str[i] = Console.ReadLine();
                if (str[i] == string.Empty)
                    break;

                if (str[i].Length <= res[i].Length)
                    res = str;

                i = i + 1;
            }

            writer.WriteLine(res);
            writer.Close();
            file_stream.Close();
        }
    }
}
