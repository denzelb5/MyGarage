using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class WaterCraft : Vehicle
    {
        public override int FuelCapacity { get; set; }
        public override int Occupancy { get; set; }
        public override string Color { get; set; }

        public string Name { get; set; }

        public WaterCraft(string name)
        {
            Name = name;
        }
    }
}
