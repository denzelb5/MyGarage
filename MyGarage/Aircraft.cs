using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Aircraft
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int Occupancy { get; set; }

        public Aircraft(int fuelCapacity, string color, int occupancy)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            Occupancy = occupancy;
        }

        public void ReFuel(int fuelCapacity)
        {
            Console.WriteLine("What is your current fuel status? Enter the estimated number of gallons left (0-100).");
            fuelCapacity = int.Parse(Console.ReadLine());
            if (fuelCapacity < 50)
            {
                Console.WriteLine("Time to refuel");
            }
            else
            {
                Console.WriteLine("Enjoy the friendly skies!");
            }
        }

        public void Fly(int occupancy, int fuelCapacity)
        {
            if (occupancy > 100 && fuelCapacity > 50)
            {
                Console.WriteLine("You have sufficient cargo and fuel.  Enjoy your flight!");
            }
            else
            {
                Console.WriteLine("Got fuel? Got passengers?");
            }
        }

        public void Land(string color)
        {
            Console.WriteLine("We only accept blue aircraft at this airport. What color is your aircraft?");
            color = Console.ReadLine();
            if (color == "blue")
            {
                Console.WriteLine("Come land on the most luxurious runway in all of North America!");
            }
            else
            {
                Console.WriteLine("Best of luck to you.  The next airport is 200 miles away.");

            }
        }
    }
}
