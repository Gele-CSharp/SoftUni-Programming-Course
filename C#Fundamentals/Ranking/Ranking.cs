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
            Dictionary<string, List<Contest>> results = new Dictionary<string, List<Contest>>();

            string[] contestInfo = Console.ReadLine().Split(':');

            while(contestInfo[0] != "end of contests")
            {
                string discipline = contestInfo[0];
                string password = contestInfo[1];

                if (contests.ContainsKey(discipline) == false)
                {
                    contests.Add(discipline, password);
                }
                else
                {
                    contests[discipline] = password;
                }

                contestInfo = Console.ReadLine().Split(':');
            }

            string[] userInfo = Console.ReadLine().Split(new string[] { "=", ">" }, StringSplitOptions.RemoveEmptyEntries);

            while (userInfo[0] != "end of submissions")
            {
                string discipline = userInfo[0];
                string password = userInfo[1];
                string name = userInfo[2];
                int points = int.Parse(userInfo[3]);

                Contest contest = new Contest(discipline, points);

                if (contests.ContainsKey(discipline) && contests[discipline] == password)
                {
                    if (results.ContainsKey(name) == false)
                    {
                        results.Add(name, new List<Contest> { contest });
                    }
                    else
                    {
                        if (results[name].Select(r=>r.Discipline).Contains(discipline))
                        {
                            results[name].Find(r => r.Discipline == discipline).UpdatePoints(points);
                        }
                        else
                        {
                            results[name].Add(contest);
                        }
                    }
                }

                userInfo = Console.ReadLine().Split(new string[] { "=", ">" }, StringSplitOptions.RemoveEmptyEntries);
            }

            string bestCandidate = string.Empty;
            int bestPoints = 0;
            int sumOfPoints = 0;

            foreach (var user in results)
            {
                foreach (var contest in user.Value)
                {
                    sumOfPoints += contest.Points;
                }

                if (sumOfPoints > bestPoints)
                {
                    bestPoints = sumOfPoints;
                    bestCandidate = user.Key;
                }

                sumOfPoints = 0;
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in results.OrderBy(u=>u.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var contest in user.Value.OrderByDescending(u=>u.Points))
                {
                    Console.WriteLine($"#  {contest.Discipline} -> {contest.Points}");
                }
            }
        }
    }

    class Contest
    {
        public Contest(string discipline, int points)
        {
            Discipline = discipline;
            Points = points;
        }

        public string Discipline { get; set; }
        public int Points { get; set; }

        public void UpdatePoints (int points)
        {
            if (this.Points < points)
            {
                this.Points = points;
            }
        }
    }
}
