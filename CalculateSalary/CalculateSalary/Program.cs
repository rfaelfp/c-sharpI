using System;
using System.Globalization;
using CalculateSalary.Entities;
using CalculateSalary.Entities.Enum;

namespace CalculateSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departament departament;
            Worker worker;
            HourContract hourContract;
            WorkerLevel workerLevel;

            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            departament = new Departament(departmentName);

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior: ");
            workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            worker = new Worker(name, workerLevel, baseSalary, departament);
            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());

            for(int i = 0; i < contracts; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                hourContract = new HourContract(date, value, duration);
                worker.AddContract(hourContract);
            }
            
            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3, 4));

            worker.Income(year, month);
            Console.WriteLine(worker);
        }
    }
}
