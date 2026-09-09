using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Email Notification ---");
            NotificationFactory emailFactory = new EmailFactory();
            emailFactory.NotifyUser("Welcome via Email!");

            Console.WriteLine("\n--- SMS Notification ---");
            NotificationFactory smsFactory = new SmsFactory();
            smsFactory.NotifyUser("Welcome via SMS!");

            Console.WriteLine("\n--- Push Notification ---");
            NotificationFactory pushFactory = new PushFactory();
            pushFactory.NotifyUser("Welcome via Push Notification!");
        }
    }
}
