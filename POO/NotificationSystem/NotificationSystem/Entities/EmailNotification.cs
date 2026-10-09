using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Entities
{
    internal class EmailNotification : Notification
    {
        public string Subject { get; set; }

        public EmailNotification(DateTime shippingDate, string message, string recipient, string subject) 
        : base(shippingDate, message, recipient)

        {
            Subject = subject;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Subject: " + Subject);
            sb.AppendLine("For: " + Recipient);
            sb.AppendLine("Message: " + Message);

            return sb.ToString();
        }
    }
}
