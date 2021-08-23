using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            string result = Char.IsLower(character) ? "lower-case" : "upper-case";

            Console.WriteLine(result);
        }
    }
}
