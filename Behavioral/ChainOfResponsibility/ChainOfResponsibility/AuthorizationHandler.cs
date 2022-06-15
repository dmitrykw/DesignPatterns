using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class AuthorizationHandler : AbstractHandler
    {
        public override bool HandleRequest(string request)
        {
            if (request.Contains("Smith"))
            {
                if (_nextHandler != null)
                { return _nextHandler.HandleRequest(request); }
                else { return true; }
            }

            return false;
        }
    }
}
