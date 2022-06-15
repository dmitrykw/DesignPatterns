using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ExternalProviders
{
    internal class EmailProvider
    {
        internal void SendEmail(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
