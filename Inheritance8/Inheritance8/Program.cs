using System;
using System.Globalization;
using System.Collections.Generic;
using Inheritance8.Entities;

namespace Inheritance8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new();
            Console.Write("Enter the number of payers: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data:");
                Console.Write("Individual or company (i/c)? ");
                char resp = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (resp == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                } else if (resp == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberEmployees));
                } else
                {
                    Console.WriteLine("Inválido");
                    return;
                }

            }
                Console.WriteLine("TAXES PAID:");
                double total = 0;
                foreach(TaxPayer payer in taxPayers)
                {
                    Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                    total += payer.Tax();
                }
                Console.WriteLine("TOTAL TAXES: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
