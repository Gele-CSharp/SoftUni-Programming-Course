using System;
using System.Collections.Generic;
using System.Linq;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<char> result = new List<char>();

            result = input.Where(i => i > firstChar && i < secondChar).ToList();
            int sum = 0;

            foreach (var character in result)
            {
                sum += character;
            }

            Console.WriteLine(sum);
        }
    }
}
