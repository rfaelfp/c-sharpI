using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using set1.Entities;


namespace set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1], CultureInfo.InvariantCulture);
                        set.Add(new LogRecord(name, instant));
                    }
                    Console.WriteLine("Total users: " + set.Count);
                } 

            } catch (IOException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
