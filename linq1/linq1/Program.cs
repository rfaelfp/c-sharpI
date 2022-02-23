using System;
using System.Linq;

namespace linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            var result = numbers
                .Where(p => p % 2 == 0)
                .Select(p => p * 10);

            // Execute the query
            foreach(int x in result) {
                Console.WriteLine(x);
            }


        }
    }
}
