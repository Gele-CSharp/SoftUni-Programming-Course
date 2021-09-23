using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<int> pumpIndexes = new Queue<int>();
            Queue<int> distances = new Queue<int>();
            Queue<int> pumpCapacities = new Queue<int>();
            int petrolQuantity = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int capacityOfPump = input[0];
                int distanceToNextPump = input[1];

                distances.Enqueue(distanceToNextPump);
                pumpCapacities.Enqueue(capacityOfPump);
            }

            int index = 0;

            while (pumpIndexes.Count < numberOfPumps)
            {
                int capacityOfPump = pumpCapacities.Peek();
                int distanceToNextPump = distances.Peek();

                if ((petrolQuantity + capacityOfPump) / distanceToNextPump >= 1)
                {
                    pumpIndexes.Enqueue(index);
                    pumpCapacities.Dequeue();
                    pumpCapacities.Enqueue(capacityOfPump);
                    distances.Dequeue();
                    distances.Enqueue(distanceToNextPump);
                    petrolQuantity += capacityOfPump - distanceToNextPump;
                }
                else
                {
                    pumpIndexes.Clear();
                    petrolQuantity = 0;
                    pumpCapacities.Dequeue();
                    pumpCapacities.Enqueue(capacityOfPump);
                    distances.Dequeue();
                    distances.Enqueue(distanceToNextPump);
                }

                index++;

                if (index == numberOfPumps)
                {
                    index = 0;
                }
            }

            Console.WriteLine(pumpIndexes.Dequeue());
        }
    }
}
