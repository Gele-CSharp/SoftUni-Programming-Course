using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMassages = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> decryptedInformation = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfMassages; i++)
            {
                string encryptedMassege = Console.ReadLine();
                string decryptedMassege = string.Empty;
                int keyValue = 0;

                for (int j = 0; j < encryptedMassege.Length; j++)
                {
                    char symbol = encryptedMassege[j];

                    if (symbol == 'S' || symbol == 's'
                     || symbol == 'T' || symbol == 't'
                     || symbol == 'A' || symbol == 'a'
                     || symbol == 'R' || symbol == 'r')

                    {
                        keyValue++;
                    }
                }

                for (int k = 0; k < encryptedMassege.Length; k++)
                {
                    char decryptedSymbol = Convert.ToChar(Convert.ToInt32(encryptedMassege[k]) - keyValue);
                    decryptedMassege += decryptedSymbol;
                }

                string orderPattern = @"@([a-zA-Z]+)[^@\-\!:>]*:([0-9]+)[^@\-\!:>]*!([A]{0,1}[D]{0,1})![^@\-\!:>]*->([0-9]+)";

                Match order = Regex.Match(decryptedMassege, orderPattern);

                if (order.Success)
                {
                    string planet = order.Groups[1].Value;
                    string action = order.Groups[3].Value;

                    if (action == "A" || action == "D")
                    {
                        if (decryptedInformation.ContainsKey(action))
                        {
                            decryptedInformation[action].Add(planet);
                        }
                        else
                        {
                            decryptedInformation.Add(action, new List<string>() { planet });
                        }
                    }
                }
            }

            Dictionary<string, List<string>> attactedPlanets = decryptedInformation.Where(a => a.Key == "A").ToDictionary(a=>a.Key, a=>a.Value);

            int attactedPlanetsCount = attactedPlanets.Sum(a => a.Value.Count);

            Console.WriteLine($"Attacked planets: {attactedPlanetsCount}");

            foreach (var attactedPlanet in attactedPlanets)
            {
                foreach (var planet in attactedPlanet.Value.OrderBy(p=>p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Dictionary<string, List<string>> destroyedPlanets = decryptedInformation.Where(d => d.Key == "D").ToDictionary(d=>d.Key, d=>d.Value);

            int destroyedPlanetsCount = destroyedPlanets.Sum(d => d.Value.Count);

            Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");

            foreach (var destroyedPlanet in destroyedPlanets)
            {
                foreach (var planet in destroyedPlanet.Value.OrderBy(p=>p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
