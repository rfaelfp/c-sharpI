using System;
using System.Globalization;
using ControleFornecedor.Entities;
using ControleFornecedor.Entities.Enums;

namespace ControleFornecedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());


            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, orderStatus, client);
            
            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine(order);


        }
    }
}
