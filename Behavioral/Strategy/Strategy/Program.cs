using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Navigator navigator = new Navigator();
            navigator.BuildRoute(1, 24);

            navigator.SetStrategy(new RoadStrategy());
            navigator.BuildRoute(2,15);

            navigator.SetStrategy(new WalikingStrategy());
            navigator.BuildRoute(3, 45);

            navigator.SetStrategy(new PublicTransportStrategy());
            navigator.BuildRoute(5, 75);


            Console.ReadLine();

        }
    }
}
