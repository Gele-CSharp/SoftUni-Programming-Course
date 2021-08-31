using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            string[] vehicleInfo = Console.ReadLine().Split('/');

            while (vehicleInfo[0] != "end")
            {
                string type = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];

                if (type == "Car")
                {
                    int horsePower = int.Parse(vehicleInfo[3]);
                    Car car = new Car(brand, model, horsePower);
                    cars.Add(car);
                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(vehicleInfo[3]);
                    Truck truck = new Truck(brand, model, weight);
                    trucks.Add(truck);
                }

                vehicleInfo = Console.ReadLine().Split('/');
            }

            Catalogue catalogue = new Catalogue(trucks, cars);

            if (catalogue.cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalogue.cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Horsepower}hp");
                }
            }    

            if (catalogue.trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalogue.trucks.OrderBy(t=>t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsepower)
        {
            Brand = brand;
            Model = model;
            Horsepower = horsepower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
    }

    class Catalogue
    {
        public Catalogue(List<Truck> trucks, List<Car> cars)
        {
            this.trucks = trucks;
            this.cars = cars;
        }

        public List<Truck> trucks { get; set; }
        public List<Car> cars { get; set; }
    }
}
