using System;
using System.Collections.Generic;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lengths = Console.ReadLine().Split();
            int firstSetLength = int.Parse(lengths[0]);
            int secondSetLength = int.Parse(lengths[1]);
            int totalLength = firstSetLength + secondSetLength;

            HashSet<string> firstSet = new HashSet<string>();
            HashSet<string> secondSet = new HashSet<string>();

            for (int i = 0; i < totalLength; i++)
            {
                string element = Console.ReadLine();

                if (i < firstSetLength)
                {
                    firstSet.Add(element);
                }
                else
                {
                    secondSet.Add(element);
                }
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
