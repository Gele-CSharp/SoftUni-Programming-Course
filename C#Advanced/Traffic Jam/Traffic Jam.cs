using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            while (input != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    if (numberOfCars >= cars.Count)
                    {
                        numberOfCars = cars.Count;
                    }

                    for (int i = 0; i < numberOfCars; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCars++;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
