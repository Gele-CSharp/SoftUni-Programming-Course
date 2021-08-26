using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                                       .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                       .ToList();

            Dictionary<string, int> participantsResults = new Dictionary<string, int>();

            string namePattern = @"([a-zA-Z])";
            string distancePattern = @"([0-9])";
            string participantInfo = Console.ReadLine();

            while (participantInfo != "end of race")
            {
                MatchCollection currentParticipant = Regex.Matches(participantInfo, namePattern);
                string participantName = string.Empty;

                foreach (var item in currentParticipant)
                {
                    participantName += item.ToString();
                }

                MatchCollection currentDistance = Regex.Matches(participantInfo, distancePattern);
                int distance = 0;

                foreach (var item in currentDistance)
                {
                    distance += int.Parse(item.ToString());
                }

                if (participants.Contains(participantName))
                {
                    if (participantsResults.ContainsKey(participantName))
                    {
                        participantsResults[participantName] += distance;
                    }
                    else
                    {
                        participantsResults.Add(participantName, distance);
                    }
                }

                participantInfo = Console.ReadLine();
            }

            List<string> results = participantsResults.OrderByDescending(p => p.Value).Select(p => p.Key).ToList();

            if (results.Count >= 3)
            {
                Console.WriteLine($"1st place: {results[0]}");
                Console.WriteLine($"2nd place: {results[1]}");
                Console.WriteLine($"3rd place: {results[2]}");
            }
            else if (results.Count == 2)
            {
                Console.WriteLine($"1st place: {results[0]}");
                Console.WriteLine($"2nd place: {results[1]}");
            }
            else if (results.Count == 1)
            {
                Console.WriteLine($"1st place: {results[0]}");
            }
        }
    }
}
