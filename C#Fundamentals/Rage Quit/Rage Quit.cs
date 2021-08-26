using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([!-/\s*:-~]+)([0-9]+)";
            string currentSymbols = string.Empty;
            StringBuilder result = new StringBuilder();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                int i = 1;
                string symbols = item.Groups[i].Value.ToString().ToUpper();
                int repeats = Convert.ToInt32(item.Groups[i+1].Value);
                currentSymbols = string.Concat(Enumerable.Repeat(symbols, repeats));
                //result = string.Join(symbols, new string[repeats+1]);
                result.Append(currentSymbols);
                i++;
            }

            string uniqueSymbols = string.Empty;

            for (int i = 1; i < result.Length; i++)
            {
                char currentCharacter = result[i];

                if (uniqueSymbols.Contains(currentCharacter))
                {
                    continue;
                }
                else
                {
                    uniqueSymbols += currentCharacter;
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
            Console.WriteLine(result.ToString());
        }
    }
}
