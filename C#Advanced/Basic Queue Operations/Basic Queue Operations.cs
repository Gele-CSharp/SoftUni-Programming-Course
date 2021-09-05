using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queuedElements = new Queue<int>(elements);

            int numberOfElementsToDequeue = input[1];
            int wantedElement = input[2];
            int smallestElement = int.MaxValue;

            for (int i = 0; i < numberOfElementsToDequeue; i++)
            {
                queuedElements.Dequeue();
            }

            foreach (int element in queuedElements)
            {
                if (element == wantedElement)
                {
                    Console.WriteLine("true");
                    return;
                }
                else if (element < smallestElement)
                {
                    smallestElement = element;
                }
            }

            if (queuedElements.Count == 0)
            {
                smallestElement = 0;
            }

            Console.WriteLine(smallestElement);
        }
    }
}
