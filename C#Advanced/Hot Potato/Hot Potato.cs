using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int numberOfTosses = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);

            while (kids.Count > 1)
            {
                for (int i = 1; i < numberOfTosses; i++)
                {
                    string kid = kids.Dequeue();
                    kids.Enqueue(kid);
                }

                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
