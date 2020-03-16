using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class WaterCraft
    {
        public int FuelCapacity { get; set; }
        public int Occupancy { get; set; }
        public string Color { get; set; }

        public WaterCraft(int fuelCapacity, int occupancy, string color)
        {
            FuelCapacity = fuelCapacity;
            Occupancy = occupancy;
            Color = color;
        }
    }
}
