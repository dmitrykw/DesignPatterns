using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class CorrectRequestHandler : AbstractHandler
    {
        public override bool HandleRequest(string request)
        {
           if (request != null && request.Count() > 3)
           {
                if (_nextHandler != null)
                { return _nextHandler.HandleRequest(request); }
                else { return true; }
           }

           return false;
        }
    }
}
