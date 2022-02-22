using System;
using Generics1.Entities;

namespace Generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int amount = int.Parse(Console.ReadLine());

            PrintService<int> printService = new PrintService<int>();
            for(int i = 0; i < amount; i++)
            {
                int value = int.Parse(Console.ReadLine());
                printService.AddValue(value);
            }
            printService.Print();
        }
    }
}
