using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderCollectionExercise.Entities.Enums;


namespace OrderCollectionExercise.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        public double PriceTotal { get; set; }

        public Order()
        { }

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem item in Item)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order Items: ");

            foreach (var item in Item)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: " + Total().ToString("F2"));

            return sb.ToString();
        }
    }
}
