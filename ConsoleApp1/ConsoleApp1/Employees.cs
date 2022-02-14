using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees (int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void increaseSalary(double percentege)
        {
            Salary += (Salary / 100) * percentege;
        }
    }
}
