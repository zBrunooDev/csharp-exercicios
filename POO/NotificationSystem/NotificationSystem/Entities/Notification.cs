using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Entities
{
    internal class Notification
    {
        public DateTime ShippingDate { get; set; }
        public string Message { get; set; }
        public string Recipient { get ; set; }

        public Notification(DateTime shippingDate, string message, string recipient)
        {
            ShippingDate = shippingDate;
            Message = message;
            Recipient = recipient;
        }

    }
}
