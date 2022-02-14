using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using ControleFornecedor.Entities.Enums;


namespace ControleFornecedor.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItem.Add(orderItem);
        }

        public void RemoveItem(OrderItem order)
        {
            OrderItem.Remove(order);
        }

        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in OrderItem)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
