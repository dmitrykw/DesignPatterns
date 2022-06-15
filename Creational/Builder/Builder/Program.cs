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
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manual construction
            Console.WriteLine("Конструируем электро-машину вручную");

            ElectroCarBuilder electroCarBuilder = new ElectroCarBuilder();
            electroCarBuilder.SetEngine(new ElectroEngine());
            electroCarBuilder.SetSeats(new List<ISeat>() { new RegularSeat(), new RegularSeat() , new RegularSeat() , new RegularSeat() });
            electroCarBuilder.SetGPS(new GPS());
            electroCarBuilder.SetTripComputer(new TripComputer());

            ElectroCar electroCar = electroCarBuilder.GetResultCar();
            electroCarBuilder.ResetBuilder();

            Console.WriteLine(electroCar.Name + "\n" + electroCar.Description);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Construction by Coordinator
            Console.WriteLine("Конструируем обычную машину при помощи класса координатора");

            Coordinator coordinator = new Coordinator();
            RegularCarBuilder regularCarBuilder = new RegularCarBuilder();
            RegularCar regularCar = coordinator.ConstructRegularCar(regularCarBuilder);
            regularCarBuilder.ResetBuilder();

            Console.WriteLine(regularCar.Name + "\n" + regularCar.Description);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Конструируем обычную машину со спортивными сиденьями при помощи класса координатора");
            RegularCar regularCar_sportseats = coordinator.ConstructRegularCar_withSportSeats(regularCarBuilder);
            regularCarBuilder.ResetBuilder();
            Console.WriteLine(regularCar_sportseats.Name + "\n" + regularCar_sportseats.Description);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Конструируем электро-машину с 2 сиденьями при помощи класса координатора");
            ElectroCar electroCar_2seats = coordinator.ConstructElectroCar_with2Seats(electroCarBuilder);
            electroCarBuilder.ResetBuilder();
            Console.WriteLine(electroCar_2seats.Name + "\n" + electroCar_2seats.Description);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            Console.ReadLine();
        }
    }
}
