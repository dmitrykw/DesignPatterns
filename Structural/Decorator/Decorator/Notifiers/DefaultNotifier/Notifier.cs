using Decorator.ExternalProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Notifier : INotifier
    {        
        public void SendMessage(string message)
        {
            EmailProvider emailProvider = new EmailProvider();
            emailProvider.SendEmail(message);
        }
    }
}
