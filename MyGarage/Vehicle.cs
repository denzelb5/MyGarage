using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    abstract class Vehicle
    {
        public virtual int FuelCapacity { get; set; }
        public virtual int Occupancy { get; set; }
        public virtual string Color { get; set; }


        //public Vehicle(int fuelCapacity, int occupancy, string color)
        //{
        //    FuelCapacity = fuelCapacity;
        //    Occupancy = occupancy;
        //    Color = color;
        //}

        public virtual void ReFuel()
        {
            Console.WriteLine("Your tank / battery is getting low.  Time to fuel up");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Are you wearing your seatbelt? y / n");
            var seatbelt = Console.ReadLine();
            if (seatbelt == "y")
            {
                Console.WriteLine("Let's go!");
            }
            else
            {
                Console.WriteLine("Put your seatbelt on dum-dum!");
            }
        }



        enum Colors
        {
            Blue,
            Red,
            White,
            Black,
            Charcoal,
            Silver,
            Green, 
            Tan,
            Orange,
            Purple
        }
    }
}
