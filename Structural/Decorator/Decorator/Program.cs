using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotifier notifier = new Notifier();            
            notifier = new SMSNotifier(notifier);
            notifier = new PushNotifier(notifier);
            notifier.SendMessage("My super message");

            Console.ReadLine();
        }
    }
}
