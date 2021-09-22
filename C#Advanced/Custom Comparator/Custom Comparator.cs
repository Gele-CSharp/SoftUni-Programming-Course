using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> odd = n => n % 2 != 0;
            Func<int, bool> even = n => n % 2 == 0;

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] odds = numbers.Where(n => odd(n)).ToArray();
            int[] evens = numbers.Where(n => even(n)).ToArray();

            Array.Sort(evens);
            Array.Sort(odds);

            Console.Write(string.Join(" ", evens));
            Console.Write(" ");
            Console.Write(string.Join(" ", odds));
        }
    }
}
