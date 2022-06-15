using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Components
{
    internal class LightSensor : BaseComponent
    {
        public void ActivateSensor()
        {
            _mediator.Notify(this, "Sensor Activated");
        }

        public void DisActivateSensor()
        {
            _mediator.Notify(this, "Sensor DisActivated");
        }
    }
}
