using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List< Employees > list = new List<Employees>();
            int quantidade;
            Console.Write("How many employees will be registered? ");
            quantidade = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Employee" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will hava salary increase: ");
            int idInserido = int.Parse(Console.ReadLine());
            Employees emp = list.Find(e => e.Id.Equals(idInserido));
            if (emp != null) 
            {
                Console.Write("Enter the percentage: ");
                double percentege = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentege);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }


            Console.WriteLine("Updated list of employees:");
            foreach(Employees i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
