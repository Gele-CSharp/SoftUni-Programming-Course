using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z]{1}[a-z]+\s{1}[A-Z]{1}[a-z]+\b";
            var regex = new Regex(pattern);

            MatchCollection names = Regex.Matches(input, pattern);

            foreach (Match name in names)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
