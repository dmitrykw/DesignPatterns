using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Components
{
    internal class Lamp : BaseComponent
    {
        public void ActivateLamp()
        {
            _mediator.Notify(this, "Lamp Activated");
        }

        public void DisActivateLamp()
        {
            _mediator.Notify(this, "Lamp DisActivated");
        }
    }
}
