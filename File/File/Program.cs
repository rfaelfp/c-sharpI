using System;
using System.IO;

namespace File
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";
            string[] lines = System.IO.File.ReadAllLines(sourcePath);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

            } catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }

    }
}
