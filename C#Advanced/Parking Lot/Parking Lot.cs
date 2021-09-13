using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        private static object hashset;

        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                string direction = input[0];
                string carNumber = input[1];

                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    cars.Remove(carNumber);
                }    

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string carNumber in cars)
                {
                    Console.WriteLine(carNumber);
                }
            }
        }
    }
}
