using System.Collections.Generic;
using System.Text;


namespace Inheritance4.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PAYMENTS:");
            foreach (Employee employee in Employees)
            {
                sb.Append(Name).Append(" - $ ");
                sb.Append(employee.Payment());
            }
            return sb.ToString();
        }
    }

}
