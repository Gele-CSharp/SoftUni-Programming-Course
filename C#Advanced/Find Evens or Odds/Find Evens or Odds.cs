using System;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int startIndex = bounds[0];
            int endIndex = bounds[1];
            string filter = Console.ReadLine();

            Predicate<int> odd = num => num % 2 != 0;
            Predicate<int> even = num => num % 2 == 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (filter == "odd" && odd(i))
                {
                    Console.Write($"{i} ");
                }
                else if (filter == "even" && even(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
