using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<int> uniqueDividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToHashSet();

            List<int> dividers = uniqueDividers.ToList();

            Func<int, int, bool> division = (a, b) => a % b == 0;
            HashSet<int> result = new ();

            for (int i = 1; i <= n; i++)
            {
                bool isDivisible = true;

                for (int j = 0; j < dividers.Count; j++)
                {
                    if (division(i, dividers[j]))
                    {
                        result.Add(i);
                    }
                    else
                    {
                        result.Remove(i);
                        isDivisible = false;
                        break;
                    }

                    if (isDivisible == false)
                    {
                        break;
                    }
                }
            }

            Console.Write(string.Join(" ", result));
        }
    }
}
