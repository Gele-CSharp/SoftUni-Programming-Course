using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int numberOfCycles = orders.Count;
            int biggestOrder = int.MinValue;

            foreach (int item in orders)
            {
                if (item > biggestOrder)
                {
                    biggestOrder = item;
                }
            }

            for (int i = 0; i < numberOfCycles; i++)
            {
                int order = orders.Peek();

                if (quantityOfFood - order >= 0)
                {
                    if (orders.Peek() > biggestOrder)
                    {
                        biggestOrder = orders.Peek();
                    }

                    quantityOfFood -= orders.Dequeue();
                }
                else
                {
                    if (biggestOrder != int.MinValue)
                    {
                        Console.WriteLine(biggestOrder);
                    }

                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }    
            }

            Console.WriteLine(biggestOrder);
            Console.WriteLine("Orders complete");
        }
    }
}
