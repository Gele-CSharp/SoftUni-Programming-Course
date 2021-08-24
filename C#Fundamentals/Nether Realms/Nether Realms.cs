using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> demons = new SortedDictionary<string, string>();

            string input = Console.ReadLine();
            string namePattern = @"([--}]{0,}[!-+]{0,}){1,}";

            MatchCollection demonNames = Regex.Matches(input, namePattern);

            foreach (Capture demonName in demonNames)
            {
                if (demonName.Value.Length > 0)
                {
                    string damagePattern = @"(-{0,1}\+{0,1}[0-9]+\.{0,1}[0-9]*)";

                    MatchCollection damage = Regex.Matches(demonName.Value, damagePattern);

                    double damageValue = 0;
                    int healthValue = 0;

                    foreach (Capture value in damage)
                    {
                        damageValue += Convert.ToDouble(value.Value);
                    }

                    if (demonName.Value.Contains("*"))
                    {
                        string name = demonName.Value.ToString();
                        int multiplier = name.Length;
                        name = name.Replace("*", "");
                        multiplier -= name.Length;
                        damageValue *= multiplier * 2;
                    }
                    else if (demonName.Value.Contains("/"))
                    {
                        string name = demonName.Value.ToString();
                        int divider = name.Length;
                        name = name.Replace("/", "");
                        divider -= name.Length;
                        damageValue /= divider * 2;
                    }

                    string healthPattern = @"([^+-/\*0123456789\.])";

                    MatchCollection health = Regex.Matches(demonName.Value, healthPattern);

                    foreach (Capture value in health)
                    {
                        healthValue += Convert.ToInt32(Convert.ToChar(value.Value));
                    }

                    string status = $"{healthValue} health, {damageValue:f2} damage";

                    demons.Add(demonName.Value.ToString(), status);
                }
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value}");
            }
        }
    }
}
