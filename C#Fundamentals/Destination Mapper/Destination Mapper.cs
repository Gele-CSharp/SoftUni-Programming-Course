using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string validDestinationPattern = @"([=/])([A-Z]{1}[a-zA-Z]{2,})\1";
            List<string> validDestinations = new List<string>();

            MatchCollection matchedDestinations = Regex.Matches(destinations, validDestinationPattern);

            int travelPoints = 0;

            foreach (Match destination in matchedDestinations)
            {
                validDestinations.Add(destination.Groups[2].Value);
                travelPoints += destination.Groups[2].Value.Length;
            }

            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", validDestinations));
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
