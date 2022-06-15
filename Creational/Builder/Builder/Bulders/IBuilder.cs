using Builder.CarParts.Engines;
using Builder.CarParts.GPSs;
using Builder.CarParts.Seats;
using Builder.CarParts.TripComputers;
using Builder.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Bulders
{
    internal interface IBuilder
    {
        void ResetBuilder();
        void SetSeats(List<ISeat> seats);
        void SetEngine(IEngine engine);
        void SetTripComputer(ITripComputer comp);
        void SetGPS(IGPS gps);
    }
}
