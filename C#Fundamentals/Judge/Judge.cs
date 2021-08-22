using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualStandings = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "no more time")
            {
                string username = input[0].Trim();
                string contest = input[1].Trim();
                int points = int.Parse(input[2]);

                if (results.ContainsKey(contest) == false)
                {
                    results.Add(contest, new Dictionary<string, int> { { username, points } });

                    if (individualStandings.ContainsKey(username))
                    {
                        individualStandings[username] += points;
                    }
                    else
                    {
                        individualStandings.Add(username, points);
                    }
                }    
                else
                {
                    if (results[contest].ContainsKey(username))
                    {
                        if (results[contest][username] < points)
                        {
                            individualStandings[username] -= results[contest][username];
                            individualStandings[username] += points;
                            results[contest][username] = points;
                        }
                    }
                    else
                    {
                        results[contest].Add(username, points);

                        if (individualStandings.ContainsKey(username))
                        {
                            individualStandings[username] += points;
                        }
                        else
                        {
                            individualStandings.Add(username, points);
                        }
                    }
                }

                input = Console.ReadLine().Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var contest in results)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int position = 1;

                foreach (var participant in contest.Value.OrderByDescending(p=>p.Value).ThenBy(p=>p.Key))
                {
                    Console.WriteLine($"{position}. {participant.Key} <::> {participant.Value}");

                    position++;
                }
            }

            Console.WriteLine("Individual standings:");

            int individualPosition = 1;

            foreach (var participant in individualStandings.OrderByDescending(p=>p.Value).ThenBy(p=>p.Key))
            {
                Console.WriteLine($"{individualPosition}. {participant.Key} -> {participant.Value}");

                individualPosition++;
            }
        }
    }
}
