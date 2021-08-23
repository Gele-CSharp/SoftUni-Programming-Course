using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string wordPairPattern = @"([@#]{1})([a-zA-Z]{3,})\1\1([a-zA-Z]{3,})\1";
            var pairs = new Dictionary<string, string>();
            var mirrorPairs = new List<string>();

            MatchCollection wordPairs = Regex.Matches(text, wordPairPattern);

            foreach (Match pair in wordPairs)
            {
                string firstWord = pair.Groups[2].Value.ToString();
                string secondWord = pair.Groups[3].Value.ToString();
                char[] reverse = secondWord.ToCharArray().Reverse().ToArray();
                string reversedSecondWord = string.Join("", reverse);

                if (firstWord == reversedSecondWord)
                {
                    string mirrorPair = $"{firstWord} <=> {secondWord}";
                    mirrorPairs.Add(mirrorPair);
                }
            }

            if (wordPairs.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{wordPairs.Count} word pairs found!");

                if (mirrorPairs.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorPairs));
                }
            }
        }
    }
}
