using System;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AdditionalConsumption = 0.9;

        public Car(int tankCapacity, double fuelQuantity, double fuelConsumption) 
            : base(tankCapacity, fuelQuantity, fuelConsumption)
        {
            FuelConsumption = fuelConsumption + AdditionalConsumption;
        }
    }
}
