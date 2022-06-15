using Mediator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediators
{
    internal class SmartHomeMediator : IMediator
    {
        private Button _button;
        private LightSensor _lightSensor;
        private Lamp _lamp;

        public SmartHomeMediator(Button button, LightSensor lightSensor, Lamp lamp)
        {
            _button = button;
            _button.SetMediator(this);

            _lightSensor = lightSensor;
            _lightSensor.SetMediator(this);

            _lamp = lamp;
            _lamp.SetMediator(this);
        }

        public void Notify(BaseComponent sender, string evnt)
        {
            Console.WriteLine(sender.ToString() + " - " + evnt);

            if (sender is Button && evnt == "Clicked")
            {
                _lamp.ActivateLamp();
            }

            if (sender is LightSensor && evnt == "Sensor Activated")
            {
                _lamp.DisActivateLamp();
            }
        }
    }
}
