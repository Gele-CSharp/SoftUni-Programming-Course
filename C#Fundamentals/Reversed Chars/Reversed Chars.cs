using System;
using System.Collections.Generic;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = new List<char>(3);

            chars.Add(char.Parse(Console.ReadLine()));
            chars.Add(char.Parse(Console.ReadLine()));
            chars.Add(char.Parse(Console.ReadLine()));

            chars.Reverse();

            Console.WriteLine(string.Join(" ", chars));
        }
    }
}
