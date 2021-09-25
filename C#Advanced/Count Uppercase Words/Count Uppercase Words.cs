using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> wordsFilter = word => Char.IsUpper(word[0]);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(wordsFilter)
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
