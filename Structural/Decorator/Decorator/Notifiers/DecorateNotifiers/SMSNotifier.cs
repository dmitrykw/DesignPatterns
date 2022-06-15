using Decorator.ExternalProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SMSNotifier : AbstractDecorator
    {    
        internal SMSNotifier(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }
        public override void SendMessage(string message)
        {
            _notifier.SendMessage(message);

            SMSProvider sms_provider = new SMSProvider();
            sms_provider.SendSMS(message);
        }
    }
}
