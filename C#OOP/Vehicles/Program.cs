using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //double fuelQuantity = double.Parse(carInfo[1]);
            //double fuelConsumption = double.Parse(carInfo[2]);
            //int tankCapacity = int.Parse(carInfo[3]);

            //Vehicle car = new Car(fuelQuantity, fuelConsumption, tankCapacity);

            //string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //fuelQuantity = double.Parse(truckInfo[1]);
            //fuelConsumption = double.Parse(truckInfo[2]);
            //tankCapacity = int.Parse(truckInfo[3]);

            //Vehicle truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);

            //string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //fuelQuantity = double.Parse(busInfo[1]);
            //fuelConsumption = double.Parse(busInfo[2]);
            //tankCapacity = int.Parse(busInfo[3]);

            //Vehicle bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);


            //int numberOfCommands = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numberOfCommands; i++)
            //{
            //    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    string action = command[0];
            //    string vehicleType = command[1];

            //    if (action == "Drive")
            //    {
            //        double distance = double.Parse(command[2]);

            //        if (vehicleType == "Car")
            //        {
            //            car.Drive(distance);
            //        }
            //        else if (vehicleType == "Truck")
            //        {
            //            truck.Drive(distance);
            //        }
            //    }
            //    else if (action == "Refuel")
            //    {
            //        double liters = double.Parse(command[2]);

            //        if (vehicleType == "Car")
            //        {
            //            car.Refuel(liters);
            //        }
            //        else if (vehicleType == "Truck")
            //        {
            //            truck.Refuel(liters);
            //        }
            //    }
            //}

            //Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            //Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            List<Vehicle> vehicles = new List<Vehicle>();

            for (int i = 1; i <= 3; i++)
            {
                string[] vehicleInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vehicleType = vehicleInfo[0];
                double fuelQuantity = double.Parse(vehicleInfo[1]);
                double fuelConsumption = double.Parse(vehicleInfo[2]);
                int tankCapacity = int.Parse(vehicleInfo[3]);


                if (vehicleType == "Car")
                {
                    Vehicle car = new Car(tankCapacity, fuelQuantity, fuelConsumption);
                    vehicles.Add(car);
                }
                else if (vehicleType == "Truck")
                {
                    Vehicle truck = new Truck(tankCapacity, fuelQuantity, fuelConsumption);
                    vehicles.Add(truck);
                }
                else if (vehicleType == "Bus")
                {
                    Bus bus = new Bus(tankCapacity, fuelQuantity, fuelConsumption);
                    vehicles.Add(bus);
                }
            }

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string vehicleType = command[1];

                Vehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);

                if (action == "Drive")
                {
                    double distance = double.Parse(command[2]);

                    vehicle.Drive(distance);
                }
                else if (action == "DriveEmpty")
                {
                    double distance = double.Parse(command[2]);

                    ((Bus)vehicle).DriveEmpty(distance);
                }
                else if (action == "Refuel")
                {
                    double liters = double.Parse(command[2]);

                    vehicle.Refuel(liters);
                }
            }

            foreach (var vehicle  in vehicles)
            {
                Console.WriteLine($"{vehicle.GetType().Name}: {vehicle.FuelQuantity:f2}");
            }
        }
    }
}
