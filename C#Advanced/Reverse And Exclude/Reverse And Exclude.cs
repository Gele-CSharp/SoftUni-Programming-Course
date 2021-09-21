using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse).ToList();

            int filterValue = int.Parse(Console.ReadLine());

            numbers
                .Where(n => n % filterValue != 0)
                .Reverse().ToList()
                .ForEach(n => Console.Write($"{n} "));

            Console.WriteLine();
        }
    }
}
