using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Car
    {
        public int FuelCapacity { get; set; }
        public string FuelType { get; set; }
        public string Color { get; set; }
        public int Occupancy { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string color, string make, string model, int fuelCapacity, int occupancy, string fuelType) 
        {
            Color = color;
            Make = make;
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelType = fuelType;
            Occupancy = occupancy;
        }

        public void ReFuel()
        {
            Console.WriteLine("What enging type is your vehicle?  Gas or electric?");
            var answer = Console.ReadLine();
            if (answer == "gas")
            {
                Console.WriteLine("How many gallons approximately are left in your gas tank?");
                var response = Console.ReadLine();
                var tank = int.Parse(response);
                if (tank <= 3)
                {
                    Console.WriteLine("Time to refuel!");
                }
                else
                {
                    Console.WriteLine("Keep on driving!");
                }
            }
            else
            {
                Console.WriteLine("Is your battery low? y / n");
                var batteryLife = Console.ReadLine();
                if (batteryLife == "y")
                {
                    Console.WriteLine("Time to recharge your vehicle.");
                }
                else
                {
                    Console.WriteLine("Drive on!");
                }
            }
        }

        public void Drive()
        {
            Console.WriteLine("Are you wearing your seatbelt? y / n");
            var seatbelt = Console.ReadLine();
            if (seatbelt == "y")
            {
            Console.WriteLine("Throw your car in gear and hit the road!");
            }
            else
            {
                Console.WriteLine("Put your seatbelt on dum-dum!");
            }
        }

        public void Brake()
        {
            Console.WriteLine("Are you about to run over or crash into something? y/n");
            var brake = Console.ReadLine();
            if (brake == "y")
            {
                Console.WriteLine("STOP!!!");
            }
            else
            {
                Console.WriteLine("Drive on!");
            }
        }
    }
}
