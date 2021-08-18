using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (chars.ContainsKey(currentChar) && currentChar != ' ')
                {
                    chars[currentChar]++;
                }
                else if (chars.ContainsKey(currentChar) == false && currentChar != ' ')
                {
                    chars.Add(currentChar, 1);
                }

            }

            foreach (var character in chars)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
