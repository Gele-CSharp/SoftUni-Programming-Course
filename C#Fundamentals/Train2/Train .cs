using System;
using System.Collections.Generic;
using System.Linq;

namespace Train2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    int numberOfPassagers = int.Parse(input[1]);
                    listOfWagons.Add(numberOfPassagers);
                }
                else
                {
                    int numberOfPassagers = int.Parse(input[0]);

                    for (int i = 0; i < listOfWagons.Count - 1; i++)
                    {
                        if (numberOfPassagers + listOfWagons[i] <= maxCapacityOfWagon)
                        {
                            listOfWagons[i] += numberOfPassagers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine().Split();
            }

            if (listOfWagons.Count > 0)
            {
                Console.WriteLine(string.Join(" ", listOfWagons));
            }
        }
    }
}
