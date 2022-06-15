using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class AbstractHandler : IHandler
    {
        private protected IHandler _nextHandler;
        public IHandler SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
            return this;
        }
        public abstract bool HandleRequest(string request);              
    }
}
