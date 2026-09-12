using OrderProduct.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set;} = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void addItems(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItems(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem items in Items)
            {
                sum += items.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) {Client.Email}");
            sb.AppendLine("Order Items:");
            foreach(OrderItem items in Items)
            {
                sb.AppendLine($"{items.Product.Name}, {items.Price}, Quantity: {items.Quantity}, Subtotal: {items.SubTotal()}");
            }
            sb.AppendLine($"Total Price: ${Total():F2}");

            return sb.ToString();
        }
    }
}
