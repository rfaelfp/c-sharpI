using System;
using System.Globalization;
using Interfaces2.Entities;
using Interfaces2.Service;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());


            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, installments);
        }
    }
}
