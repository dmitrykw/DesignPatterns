using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ExternalProviders
{
    internal class SMSProvider
    {
        internal void SendSMS(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }
}
