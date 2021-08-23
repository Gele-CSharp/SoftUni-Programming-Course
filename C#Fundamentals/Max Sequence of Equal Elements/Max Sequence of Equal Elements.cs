using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<string> sequence = new List<string>();
            List<string> maxSequence = new List<string>();
            int counter = 1;

            for (int i = input.Length - 1; 0 < i; i--)
            {
                if (input[i] == input[i - 1])
                {
                    counter++;
                    sequence = Enumerable.Repeat(input[i].ToString(), counter).ToList();

                    if (sequence.Count >= maxSequence.Count)
                    {
                        maxSequence = sequence;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine(string.Join(" ", maxSequence));
        }
    }
}
