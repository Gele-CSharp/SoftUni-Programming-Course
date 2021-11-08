using System;

namespace Vehicles
{
    public class Bus : Vehicle, IDriveEmpty
    {
        private const double AdditionalConsumption = 1.4; 

        public Bus(int tankCapacity, double fuelQuantity, double fuelConsumption) 
            : base(tankCapacity, fuelQuantity, fuelConsumption)
        {
            FuelConsumption = fuelConsumption + AdditionalConsumption;
        }

        public void DriveEmpty(double distance)
        {
            FuelConsumption -= AdditionalConsumption;

            if (distance * FuelConsumption <= FuelQuantity)
            {
                FuelQuantity -= distance * FuelConsumption;
                Console.WriteLine($"{nameof(Bus)} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{nameof(Bus)} needs refueling");
            }
        }
    }
}
