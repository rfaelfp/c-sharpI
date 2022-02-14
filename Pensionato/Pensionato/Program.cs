using System;

namespace Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reservas[] reservas = new Reservas[10];
            int quantidade;
            Console.Write("How many rooms will be rented? ");
            quantidade = int.Parse(Console.ReadLine());



            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Rent #" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                reservas[room] = new Reservas(name, email);
            }

            Console.WriteLine("Busy Romms:");
            for (int i = 0; i < reservas.Length; i++)
            {
                if (reservas[i] !=  null)
                {
                    Console.WriteLine(i + ": " + reservas[i]);
                }
            }
        }
    }
}
