using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class AbstractDecorator : INotifier
    {
        private protected INotifier _notifier;
        internal AbstractDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public abstract void SendMessage(string message);
    }
}
