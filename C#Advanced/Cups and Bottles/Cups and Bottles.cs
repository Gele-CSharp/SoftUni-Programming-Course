using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacityInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int wastedWater = 0;

            Stack<int> bottles = new Stack<int>(bottlesInfo);
            Queue<int> cups = new Queue<int>(cupsCapacityInfo);

            while (cups.Count > 0 && bottles.Count > 0)
            {
                if (bottles.Peek() - cups.Peek() >= 0)
                {
                    wastedWater += bottles.Pop() - cups.Dequeue();
                }
                else
                {
                    int cupCapacity = cups.Peek();
                     
                    while (cupCapacity > 0)
                    {
                        cupCapacity -= bottles.Pop();
                    }

                    if (cupCapacity < 0)
                    {
                        wastedWater -= cupCapacity;
                    }

                    cups.Dequeue();
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
