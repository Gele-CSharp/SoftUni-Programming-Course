using System;
using System.Linq;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            Func<string, int, bool> filter = (name, nameLength) => name.Length <= nameLength;

            Console.ReadLine()
                .Split()
                .Where(n => filter(n, nameLength))
                .ToList()
                .ForEach(n => Console.WriteLine(n));
        }
    }
}
