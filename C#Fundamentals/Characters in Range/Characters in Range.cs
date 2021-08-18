using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharactersInRange(firstChar, secondChar);
        }

        public static void PrintCharactersInRange(char firstChar, char secondChar)
        {
            int start = firstChar <= secondChar ? firstChar : secondChar;
            int end = firstChar > secondChar ? firstChar : secondChar;

            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
