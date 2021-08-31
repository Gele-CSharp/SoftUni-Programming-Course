using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string[] vehicleInfo = Console.ReadLine().Split();

            while (vehicleInfo[0] != "End")
            {
                string type = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsepower = int.Parse(vehicleInfo[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(vehicle);

                vehicleInfo = Console.ReadLine().Split();
            }

            string modelToPrint = Console.ReadLine();

            while (modelToPrint != "Close the Catalogue")
            {
                if (vehicles.Select(x=>x.Model).Contains(modelToPrint))
                {
                    Vehicle vehicleToprint = vehicles.First(x => x.Model == modelToPrint);
                    Console.WriteLine(vehicleToprint);
                }

                modelToPrint = Console.ReadLine();
            }

            List<Vehicle> cars = vehicles.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucks = vehicles.Where(x => x.Type == "truck").ToList();

            double averageHorsepowerOfCars = 0;
            double averageHorsepowerOfTrucks = 0;

            if (cars.Count > 0)
            {
                averageHorsepowerOfCars = 1.0 * cars.Sum(x => x.Horsepower) / cars.Count;
            }

            if (trucks.Count > 0)
            {
                averageHorsepowerOfTrucks = 1.0 * trucks.Sum(x => x.Horsepower) / trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageHorsepowerOfCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsepowerOfTrucks:f2}.");
        }

        class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsepower)
            {
                Type = type;
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
                sb.AppendLine($"Model: {Model}");
                sb.AppendLine($"Color: {Color}");
                sb.AppendLine($"Horsepower: {Horsepower}");
                return sb.ToString().Trim();
            }
        }
    }
}
