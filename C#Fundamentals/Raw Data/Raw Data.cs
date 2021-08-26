using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
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
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> carsToPrint = cars.Where(c => c.Cargo.CargoType == "fragile" && c.Cargo.CargoWeight < 1000).ToList();

                foreach (Car car in carsToPrint)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                List<Car> carsToPrint = cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250).ToList();

                foreach (Car car in carsToPrint)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }

    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    class Cargo
    {
    public Cargo(int cargoWeight, string cargoType)
    {
        CargoWeight = cargoWeight;
        CargoType = cargoType;
    }

    public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }

    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
}
