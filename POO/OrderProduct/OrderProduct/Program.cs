using OrderProduct.Entities;
using OrderProduct.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);

            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Console.WriteLine("how many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i}# item  data");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(product, productQuantity, productPrice);
                
                order.Items.Add(orderItem);
            }

            Console.Write(order);
            
        }
    }
}
