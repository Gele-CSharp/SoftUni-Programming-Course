using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public Vehicle(int tankCapacity, double fuelQuantity, double fuelConsumption)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;

            protected set
            {
                if (value > TankCapacity || value <= 0)
                {
                    Console.WriteLine($"Cannot fit {value} fuel in the tank");
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public virtual double FuelConsumption { get; protected set; }
               
        public virtual int TankCapacity { get; protected set; }

        public virtual void Drive(double distance)
        {
            if (distance * FuelConsumption <= FuelQuantity)
            {
                FuelQuantity -= distance * FuelConsumption;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double liters)
        {
            if (fuelQuantity + liters > TankCapacity)
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
            }
        }
    }
}
