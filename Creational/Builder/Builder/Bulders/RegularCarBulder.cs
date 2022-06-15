using Builder.CarParts;
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
    internal class RegularCarBuilder : IBuilder
    {
        List<ICarPart> _resultParts;

        internal RegularCarBuilder()
        {
            ResetBuilder();
        }

        public void ResetBuilder()
        {
            _resultParts = new List<ICarPart>();
        }

        public void SetSeats(List<ISeat> seats)
        {
            _resultParts.AddRange(seats);
        }

        public void SetEngine(IEngine engine)
        {
            _resultParts.Add(engine);
        }

        public void SetTripComputer(ITripComputer comp)
        {
            _resultParts.Add(comp);
        }

        public void SetGPS(IGPS gps)
        {
            _resultParts.Add(gps);
        }
        public RegularCar GetResultCar()
        {
            return new RegularCar(_resultParts);
        }
    }
}
