using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var carMileage = new Dictionary<string, int>();
            var carFuel = new Dictionary<string, int>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                string car = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                carMileage.Add(car, mileage);
                carFuel.Add(car, fuel);
            }

            string[] command = Console.ReadLine().Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

            
            while (command[0] != "Stop")
            {
                string car = command[1].Trim();

                if (command[0].Trim() == "Drive")
                {
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);

                    if (carFuel[car] >= fuel)
                    {
                        carFuel[car] -= fuel;
                        carMileage[car] += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (carMileage[car] >= 100000)
                        {
                            carFuel.Remove(car);
                            carMileage.Remove(car);

                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (command[0].Trim() == "Refuel")
                {
                    int fuel = int.Parse(command[2]);

                    if (carFuel[car] + fuel > 75)
                    {
                        fuel = 75 - carFuel[car];
                    }

                    carFuel[car] += fuel;

                    Console.WriteLine($"{car} refueled with {fuel} liters");
                }
                else if (command[0].Trim() == "Revert")
                {
                    int distance = int.Parse(command[2]);

                    if (carMileage[car] - distance >= 0)
                    {
                        carMileage[car] -= distance;
                    }

                    if (carMileage[car] < 10000)
                    {
                        carMileage[car] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
                    }
                }

                command = Console.ReadLine().Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in carMileage.OrderByDescending(c=>c.Value))
            {
                foreach (var car in carFuel.OrderBy(c=>c.Key).Where(c=>c.Key == item.Key))
                {
                    Console.WriteLine($"{car.Key} -> Mileage: {item.Value} kms, Fuel in the tank: {car.Value} lt.");
                }
            }
        }
    }
}
