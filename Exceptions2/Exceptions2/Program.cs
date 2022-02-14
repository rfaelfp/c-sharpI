using System;
using System.Globalization;
using Exceptions2.Entities;
using Exceptions2.Entities.Exceptions;


namespace Exceptions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, initialBalance, withdrawLimit);
                Console.Write("Enter amount for withdraw: ");
                double withdrawn = double.Parse(Console.ReadLine());
                account.Withdraw(withdrawn);

                Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));


            } catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            } catch (Exception e)
            {
                Console.WriteLine("Something happens: " + e.Message);
            }

        }
    }
}
