using System;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var Prius = new Car("red", "Toyota", "Prius", 15, 5, "Battery");
            Prius.ReFuel();
            Prius.Drive();
            Prius.Brake();

            var Airplane = new Aircraft(100, "red", 76);
            Airplane.Fly(89, 79);
            Airplane.ReFuel(79);
            Airplane.Land("red");

        }
    }
}
