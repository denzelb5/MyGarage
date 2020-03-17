using System;
using System.Collections.Generic;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car> { };

            var mustang = new Car("Ford", "Mustang");
            var mini = new Car("Mini", "Cooper");
            var tesla = new Car("Tesla", "Model S");
            var bmw = new Car("BMW", "Z3");

            cars.Add(mustang);
            cars.Add(mini);
            cars.Add(tesla);
            cars.Add(bmw);

            foreach (var car in cars)
            {
                var carName = car.Make + " " + car.Model;
            Console.WriteLine(carName);
                car.Drive();

            }

            var pontoon = new WaterCraft("Pontoon");
            var speedBoat = new WaterCraft("Speedboat");
            var cruiseShip = new WaterCraft("CruiseShip");
            var tugboat = new WaterCraft("TugBoat");

            List<WaterCraft> watercrafts = new List<WaterCraft> {pontoon, speedBoat, cruiseShip, tugboat};

            foreach (var boat in watercrafts)
            {
                Console.WriteLine(boat.Name);
                boat.Drive();
            }

            var pedalJumper = new Aircraft("PedalJumper");
            var jumboJet = new Aircraft("JumboJet");
            var helicopter = new Aircraft("Helicopter");

            List<Aircraft> aircrafts = new List<Aircraft> { pedalJumper, jumboJet, helicopter };

            foreach (var airplane in aircrafts)
            {
                Console.WriteLine(airplane.Name);
                airplane.Fly(200, 99);
            }
        }
    }
}
