using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using NotificationSystem.Entities;

namespace NotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Notification> notifications = new List<Notification>();

            string subject = "Meeting location";
            string recipient = "Bruno Lima";
            string message = "Hello, do you know of any software?";

            Notification emailNotification = new EmailNotification(DateTime.Now, message, recipient, subject);

            notifications.Add(emailNotification);

            string provider = "VIVO";
            string recipient1 = "Bruno Lima";
            string message1 = "Your statement is ready. Open the app to learn more.";

            Notification smsNotification = new SmsNotification(DateTime.Now, message1, recipient1, provider);

            notifications.Add(smsNotification);

            foreach (Notification notification in notifications)
            {
                if (notification is EmailNotification email)
                {
                    Console.WriteLine(email.Subject);
                }

                SmsNotification sms = notification as SmsNotification;

                if(sms != null)
                {
                    Console.WriteLine(sms.Provider);
                }

                Console.WriteLine(notification);
            }
            

        }
    }
}
