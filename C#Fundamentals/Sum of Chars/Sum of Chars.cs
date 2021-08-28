using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfChars; i++)
            {
                char character = char.Parse(Console.ReadLine());

                sum += Char.IsLower(character) ? (int)(character) : (int)(character);
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
