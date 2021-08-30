using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] key = Console.ReadLine().Split();
            string input = Console.ReadLine();
            StringBuilder decypheredText = new StringBuilder();

            while (input != "find")
            {
                int currentKey = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    int keyValue = int.Parse(key[currentKey]);
                    currentKey++;

                    if (currentKey >= key.Length)
                    {
                        currentKey = 0;
                    }

                    char currentChar = Convert.ToChar(input[i] - keyValue);
                    decypheredText.Append(currentChar);
                }

                string treajurePattern = @"&([A-z]+)&[A-z]+<([0-9]{2}[A-Z]{1}[0-9]{2}[A-Z]{1})>";

                Match treajureTypeAndCoordinates = Regex.Match(decypheredText.ToString(), treajurePattern);

                if (treajureTypeAndCoordinates.Success)
                {
                    Console.WriteLine($"Found {treajureTypeAndCoordinates.Groups[1]} at {treajureTypeAndCoordinates.Groups[2]}");
                }

                decypheredText.Clear();
                input = Console.ReadLine();
            }
        }
    }
}
