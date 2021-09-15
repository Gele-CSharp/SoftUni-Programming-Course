using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(":");

            while (input[0] != "end of contests")
            {
                string contest = input[0];
                string password = input[1];

                if (contests.ContainsKey(contest) == false)
                {
                    contests.Add(contest, "");
                }

                contests[contest] = password;

                input = Console.ReadLine().Split(":");
            }

            string[] contestInfo = Console.ReadLine().Split("=>");

            while (contestInfo[0] != "end of submissions")
            {
                string contest = contestInfo[0];
                string password = contestInfo[1];
                string username = contestInfo[2];
                int result = int.Parse(contestInfo[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (candidates.ContainsKey(username) == false)
                    {
                        candidates.Add(username, new Dictionary<string, int>());
                    }

                    if (candidates[username].ContainsKey(contest) == false)
                    {
                        candidates[username].Add(contest, 0);
                    }

                    if (candidates[username][contest] < result)
                    {
                        candidates[username][contest] = result;
                    }
                }

                contestInfo = Console.ReadLine().Split("=>");
            }

            int bestpoints = int.MinValue;
            string bestCandidate = string.Empty;

            foreach (string candidate in candidates.Keys)
            {
                int points = 0;

                foreach (var result in candidates[candidate].Select(c=>c.Value))
                {
                    points += result;

                    if (points > bestpoints)
                    {
                        bestpoints = points;
                        bestCandidate = candidate;
                    }
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestpoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var candidate in candidates.OrderBy(c=>c.Key))
            {
                string currentCandidate = candidate.Key;

                Console.WriteLine(currentCandidate);

                foreach (var result in candidates[currentCandidate])
                {
                    Console.WriteLine($"#  {result.Key} -> {result.Value}");
                }
            }
        }
    }
}
