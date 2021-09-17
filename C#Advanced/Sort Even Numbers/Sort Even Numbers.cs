using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> evenNumbers = Console.ReadLine()
                                   .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .Where(n => n % 2 == 0)
                                   .OrderBy(n => n)
                                   .ToList();

            Console.Write(string.Join(", ", evenNumbers));
        }
    }
}
