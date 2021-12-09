using System;
using System.IO;

namespace PZ_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string fol_path = @"C:\SOME FOLDER";
            string path1 = @"C:\SOME FOLDER\f1.txt";
            string path2 = @"C:\SOME FOLDER\f2.txt";

            if (!Directory.Exists(fol_path))
                Directory.CreateDirectory(fol_path);

            if (!File.Exists(path1))
                File.Create(path1).Close();

            if (!File.Exists(path2))
                File.Create(path2).Close();

            string[] lines;

            using (FileStream file_stream = new FileStream(path1, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(file_stream))
                {
                    string allText = reader.ReadToEnd();
                    lines = new string[allText.Split('\n').Length];

                    for (int i = 0; i < lines.Length; i++)
                        lines[i] = reader.ReadLine();
                }
            }
            using (FileStream file_stream = new FileStream(path2, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file_stream))
                {
                    for (int i = 0; i < lines.Length / 2; i++)
                        writer.WriteLine(lines[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
