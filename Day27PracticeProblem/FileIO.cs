using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27FileIO
{
    internal class FileIO
    {
        public static void FileExists()
        {
            string path = @"C:\Users\milan\source\repos\FileIODemo\FileIODemo\TextFile1.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = @"C:\Users\milan\source\repos\FileIODemo\FileIODemo\TextFile1.txt";
            String[] lines;

            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

        public static void ReadAllText()
        {
            String path = @"C:\Users\milan\source\repos\FileIODemo\FileIODemo\TextFile1.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }

        public static void FileCopy()
        {
            String path = @"C:\Users\milan\source\repos\FileIODemo\FileIODemo\TextFile1.txt";
            String copypath = @"C:\Users\milan\source\repos\FileIODemo\FileIODemo\Demo.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            String path = @"C:\Users\milan\source\repos\FileIODemo\FileIODemo\Demo.txt";

            File.Delete(path);

        }

        public static void ReadFromStreamReader()
        {
            String path = @"C:\Users\milan\source\repos\FileIODemo\FileIODemo\TextFile1.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"C:\Users\milan\source\repos\FileIODemo\FileIODemo\TextFile1.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome1");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
