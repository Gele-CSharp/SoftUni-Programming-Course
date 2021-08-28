using System;
using System.Collections.Generic;

namespace Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(numberOfCars);

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);
                double traveledDistance = 0;

                Car car = new Car(model, fuelAmount, fuelConsumption, traveledDistance);
                cars.Add(car);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string carModel = command[1];
                double distance = double.Parse(command[2]);

                cars.Find(c => c.Model == carModel).IsDrivePossible(distance);

                command = Console.ReadLine().Split();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {(int)(car.TraveledDistance)}");
            }
        }
    }

    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption, double traveledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            TraveledDistance = traveledDistance;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }

        public void IsDrivePossible(double distance)
        {
            double possibleDistance = this.FuelAmount / this.FuelConsumption;

            if (possibleDistance >= distance)
            {
                this.FuelAmount -= distance * this.FuelConsumption;
                this.TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
