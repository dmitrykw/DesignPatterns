using Decorator.ExternalProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class PushNotifier : AbstractDecorator
    {        
        internal PushNotifier(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }
        public override void SendMessage(string message)
        {
            _notifier.SendMessage(message);

            PushProvider push_provider = new PushProvider();
            push_provider.SendPush(message);
        }
    }
}
