using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Lake lake = new Lake(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            List<int> output = new List<int>();

            foreach (var stone in lake)
            {
                output.Add(stone);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
