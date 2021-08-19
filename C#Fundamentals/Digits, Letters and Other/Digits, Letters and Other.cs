using System;
using System.Linq;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] digits = input.Where(i => i >= 48 && i <= 57).ToArray();
            char[] letters = input.Where(i => i >= 65 && i <= 90 || i >= 97 && i <= 122).ToArray();
            char[] otherCharacters = input.Where(i => i >= 0 && i <= 47 
                                                   || i >= 58 && i <= 64 
                                                   || i >= 91 && i <= 96 
                                                   || i >= 123 && i <= 127).ToArray();

            Console.WriteLine(string.Concat(digits));
            Console.WriteLine(string.Concat(letters));
            Console.WriteLine(string.Concat(otherCharacters));
        }
    }
}
