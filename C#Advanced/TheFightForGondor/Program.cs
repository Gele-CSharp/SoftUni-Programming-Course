using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());
            Stack<long> plates = new Stack<long>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .Reverse());

            Stack<long> warriorOrcs = new Stack<long>();

            for (int i = 1; i <= numberOfWaves; i++)
            {
                warriorOrcs = new Stack<long>(Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse));

                if (i % 3 == 0)
                {
                    plates.Push(long.Parse(Console.ReadLine()));
                    List<long> platesValues = new List<long>();

                    foreach (var plate in plates)
                    {
                        platesValues.Add(plate);
                    }

                    plates.Clear();

                    for (int j = platesValues.Count - 1; j >= 0; j--)
                    {
                        plates.Push(platesValues[j]);
                    }
                }

                while (plates.Count > 0 && warriorOrcs.Count > 0)
                {
                    if (plates.Peek() < warriorOrcs.Peek())
                    {
                        warriorOrcs.Push(warriorOrcs.Pop() - plates.Pop());
                    }
                    else if (plates.Peek() > warriorOrcs.Peek())
                    {
                        plates.Push(plates.Pop() - warriorOrcs.Pop());
                    }
                    else if (plates.Peek() == warriorOrcs.Peek())
                    {
                        plates.Pop();
                        warriorOrcs.Pop();
                    }
                }

                if (plates.Count <= 0)
                {
                    break;
                }
            }

            if (plates.Count <= 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", warriorOrcs)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}
