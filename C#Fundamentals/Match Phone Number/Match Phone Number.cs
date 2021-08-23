using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string phonePattern = @"\+359((\s*-*){1})[2]{1}\1[0-9]{3}\1[0-9]{4}\b";
            MatchCollection phones = Regex.Matches(input, phonePattern);
            List<string> result = new List<string>();

            foreach (Match phone in phones)
            {
                result.Add(phone.Value);
            }

            Console.Write(string.Join(", ", result));
            Console.WriteLine();
        }
    }
}
