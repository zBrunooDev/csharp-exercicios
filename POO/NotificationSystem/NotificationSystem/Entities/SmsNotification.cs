using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Entities
{
    internal class SmsNotification : Notification
    {
        public string Provider { get; set; }

        public SmsNotification(DateTime shippingDate, string message, string recipient, string provider)
        : base(shippingDate, message, recipient)
        {
            Provider = provider;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Provider: " + Provider);
            sb.AppendLine("For: " + Recipient);
            sb.AppendLine("Message: " + Message);

            return sb.ToString();
        }
    }
}
