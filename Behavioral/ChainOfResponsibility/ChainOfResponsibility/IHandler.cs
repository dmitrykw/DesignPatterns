using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal interface IHandler
    {
        IHandler SetNextHandler(IHandler handler);
        bool HandleRequest(string request);
    }
}
