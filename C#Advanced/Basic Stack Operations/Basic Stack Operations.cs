using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackedElements = new Stack<int>(elements);
            int smallestElement = int.MaxValue;

            int numberOfElementsToPush = input[0];
            int numberOfElementsToPop = input[1];
            int wantedElement = input[2];

            for (int i = 0; i < numberOfElementsToPop; i++)
            {
                stackedElements.Pop();
            }

            foreach (int element in stackedElements)
            {
                if (element == wantedElement)
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    if (element < smallestElement)
                    {
                        smallestElement = element;
                    }
                }
            }

            if (stackedElements.Count == 0)
            {
                smallestElement = 0;
            }

            Console.WriteLine(smallestElement);
        }
    }
}
