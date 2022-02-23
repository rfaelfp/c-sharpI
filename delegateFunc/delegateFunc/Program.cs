using System;
using System.Collections.Generic;
using System.Linq;
using delegateFunc.Entities;

namespace delegateFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> teste = NameAfter;

            List<string> result = list.Select(p => p.Name.ToUpper().ToString()).ToList();
            List<double> result2 = list.Select(p => p.Name[0] == 'T' ?? += p.Price;

            result.ForEach(p => Console.WriteLine(p));
        }
        static string NameAfter(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
