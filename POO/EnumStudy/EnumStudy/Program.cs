using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumStudy.Entities;
using EnumStudy.Entities.Enums;

namespace EnumStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {

                Id = 1462,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);

            //string to enumeration conversion
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            //I have a value in string format and I need to convert it to an enumerated type.

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(os);
        }
    }
}   