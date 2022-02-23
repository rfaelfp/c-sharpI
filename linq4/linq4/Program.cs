using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using linq4.Entities;
using System.IO;


namespace linq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> products = new List<Product>();
            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            var average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price: " + average.ToString("F2", CultureInfo.InvariantCulture));

            var names = products.Where(p => p.Price < average).OrderByDescending(p => p.Price).Select(p => p.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            

        }
    }
}
