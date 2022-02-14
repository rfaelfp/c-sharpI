using CalculateSalary.Entities.Enum;
using System.Collections.Generic;
using System.Globalization;

namespace CalculateSalary.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public double Total;
        public int Month, Year;

        public Worker() 
        {
        }
        public Worker (string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            Year = year;
            Month = month;
            double result = BaseSalary;
            foreach(HourContract l in Contracts)
            {
                if(l.Date.Year == year && l.Date.Month == month)
                {   
                    result += l.TotalValue();
                }
            }
            Total = result;
            return result;
        }

        public override string ToString()
        {
            return "Name: "
                + Name
                + "\nDepartment: "
                + Departament.Name
                + "\nIncome for "
                + Month
                + "/"
                + Year
                + ": "
                + Total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
