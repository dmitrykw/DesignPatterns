using Builder.Bulders;
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

namespace Builder
{
    internal class Coordinator
    {
        public ElectroCar ConstructElectroCar(ElectroCarBuilder builder)
        {
            builder.SetEngine(new ElectroEngine());
            builder.SetSeats(new List<ISeat>() { new RegularSeat(), new RegularSeat(), new RegularSeat(), new RegularSeat() });
            builder.SetGPS(new GPS());
            builder.SetTripComputer(new TripComputer());

            return builder.GetResultCar();
        }

        public ElectroCar ConstructElectroCar_with2Seats(ElectroCarBuilder builder)
        {
            builder.SetEngine(new ElectroEngine());
            builder.SetSeats(new List<ISeat>() { new RegularSeat(), new RegularSeat()});
            builder.SetGPS(new GPS());
            builder.SetTripComputer(new TripComputer());

            return builder.GetResultCar();
        }


        public RegularCar ConstructRegularCar(RegularCarBuilder builder)
        {
            builder.SetEngine(new RegularEngine());
            builder.SetSeats(new List<ISeat>() { new RegularSeat(), new RegularSeat(), new RegularSeat(), new RegularSeat() });
            builder.SetGPS(new GPS());
            builder.SetTripComputer(new TripComputer());

            return builder.GetResultCar();
        }

        public RegularCar ConstructRegularCar_withSportSeats(RegularCarBuilder builder)
        {
            builder.SetEngine(new RegularEngine());
            builder.SetSeats(new List<ISeat>() { new SportSeat(), new SportSeat(), new SportSeat(), new SportSeat() });
            builder.SetGPS(new GPS());
            builder.SetTripComputer(new TripComputer());

            return builder.GetResultCar();
        }
    }
}
