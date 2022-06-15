using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class AuthentificationHandler : AbstractHandler
    {
        public override bool HandleRequest(string request)
        {
           if(request.Contains("John"))
           {
                if (_nextHandler != null)
                { return _nextHandler.HandleRequest(request); }
                else { return true; }
           }

           return false;
        }
    }
}
