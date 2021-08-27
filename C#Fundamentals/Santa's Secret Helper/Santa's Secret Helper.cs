using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string encryptedMessage = Console.ReadLine();
            StringBuilder decryptedMessage = new StringBuilder();
            Dictionary<string, string> children = new Dictionary<string, string>();

            while (encryptedMessage != "end")
            {
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    int currentCharacterValue = encryptedMessage[i];
                    char currentCharacter = Convert.ToChar(currentCharacterValue - 3);
                    decryptedMessage.Append(currentCharacter);
                }

                string childInfoPattern = @"@([A-Za-z]+)[^@\-!:>][!-~]*!([GN]{1})!";

                Match childNameAndBehavior = Regex.Match(decryptedMessage.ToString(), childInfoPattern);

                if (childNameAndBehavior.Success)
                {
                    string name = childNameAndBehavior.Groups[1].Value.ToString();
                    string behavior = childNameAndBehavior.Groups[2].Value.ToString();
                    children.Add(name, behavior);
                }

                decryptedMessage.Clear();
                encryptedMessage = Console.ReadLine();
            }

            foreach (var child in children.Where(c=>c.Value == "G"))
            {
                Console.WriteLine(child.Key);
            }
        }
    }
}
