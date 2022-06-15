using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Components
{
    internal class Button : BaseComponent
    {
        public void Click()
        {
            _mediator.Notify(this, "Clicked");
        }
    }
}
