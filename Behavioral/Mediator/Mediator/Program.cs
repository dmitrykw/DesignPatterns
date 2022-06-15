using Mediator.Components;
using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            LightSensor lightSensor = new LightSensor();
            Lamp lamp = new Lamp();

            new SmartHomeMediator(button, lightSensor, lamp);

            Console.WriteLine("Включаем выключатель");
            button.Click();

            Console.WriteLine("Активировался сенсор света");
            lightSensor.ActivateSensor();

            Console.ReadLine();
        }
    }
}
