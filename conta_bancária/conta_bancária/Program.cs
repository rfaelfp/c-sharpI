using System;
using System.Globalization;

namespace conta_bancária
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine().ToUpper());

            while (resp != 'S' && resp != 'N')
            {
                Console.Write("Haverá depósito inicial (s/n)? ");
                resp = char.Parse(Console.ReadLine().ToUpper());
            }

            ContaBancaria c;

            if (resp == 'S')
            {
                Console.Write("Entre o valor de depósito judicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero , titular, saldo);
            } else
            {
                c = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            c.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}
