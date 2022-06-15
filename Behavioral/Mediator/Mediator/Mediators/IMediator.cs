using Mediator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediators
{
    internal interface IMediator
    {
        void Notify(BaseComponent sender, string evnt);
    }
}
