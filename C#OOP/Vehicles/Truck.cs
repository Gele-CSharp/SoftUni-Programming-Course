using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AdditionalConsumption = 1.6;

        public Truck(int tankCapacity, double fuelQuantity, double fuelConsumption) 
            : base(tankCapacity, fuelQuantity, fuelConsumption)
        {
            FuelConsumption = fuelConsumption + AdditionalConsumption;
        }

        public override void Refuel(double liters)
        {
            if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                FuelQuantity += liters;
                FuelQuantity -= liters * 0.05;
            }
        }
    }
}
