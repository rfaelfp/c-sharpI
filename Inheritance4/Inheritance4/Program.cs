using System;
using System.Collections.Generic;
using System.Text;
using Inheritance4.Entities;

namespace Inheritance4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());
            for (int i = 1;i <= numberEmployees; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine().ToLower());
                if (resp == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employee.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } else
                {
                    employee.Add(new Employee(name, hours, valuePerHour));
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("PAYMENTS:");
                foreach (Employee emp in employee)
                {
                    sb.Append(emp.Name).Append(" - $ ");
                    sb.Append(emp.Payment());
                }
                Console.WriteLine(sb);
            }

        }
    }
}
