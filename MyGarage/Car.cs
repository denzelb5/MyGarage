using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Car : Vehicle
    {
        public override int FuelCapacity { get; set; }
        public string FuelType { get; set; }
        public override string Color { get; set; }
        public override int Occupancy { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        
        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }


        public override void ReFuel()
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
