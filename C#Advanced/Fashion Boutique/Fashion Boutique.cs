using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valuesOfCloths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(valuesOfCloths);
            int numberOfCycles = clothes.Count;
            int numberOfRacks = 1;
            int capacityOfCurrentRack = capacityOfRack;

            while (clothes.Count > 0)
            {
                if (capacityOfCurrentRack - clothes.Peek() >= 0)
                {
                    capacityOfCurrentRack -= clothes.Pop();
                }
                else
                {
                    numberOfRacks++;
                    capacityOfCurrentRack = capacityOfRack;
                }
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}
