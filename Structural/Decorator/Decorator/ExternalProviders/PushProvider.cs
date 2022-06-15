using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ExternalProviders
{
    internal class PushProvider
    {
        internal void SendPush(string message)
        {
            Console.WriteLine("Push: " + message);
        }
    }
}
