using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> followed = new SortedDictionary<string, List<string>>();
            SortedDictionary<string, int> followers = new SortedDictionary<string, int>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Statistics")
            {
                string vlogger = command[0];
                string action = command[1];

                if (action == "joined")
                {
                    if (followed.ContainsKey(vlogger) == false)
                    {
                        followed.Add(vlogger, new List<string>());
                        followers.Add(vlogger, 0);
                    }
                }
                else if (action == "followed")
                {
                    string followedVlogger = command[2];

                    if (followed.ContainsKey(vlogger) && followed.ContainsKey(followedVlogger) && vlogger != followedVlogger)
                    {
                        if (followed[followedVlogger].Contains(vlogger) == false)
                        {
                            followed[followedVlogger].Add(vlogger);
                            followers[vlogger]++;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            SortedDictionary<string, Dictionary<int, List<string>>> vloggers = new SortedDictionary<string, Dictionary<int, List<string>>>();
            int mostFamousVloggerFowollers = int.MinValue;
            int mostFamousVloggerFollowed = int.MaxValue;
            string mostFamousVlogger = string.Empty;

            foreach (var vlogger in followed.OrderByDescending(x => x.Value.Count))
            {
                foreach (var follower in followers.Where(f => f.Key == vlogger.Key))
                {
                    int numberOfFollowedVloggers = follower.Value;
                    vloggers.Add(vlogger.Key, new Dictionary<int, List<string>> { { numberOfFollowedVloggers, new List<string>(vlogger.Value) } });

                    if (mostFamousVloggerFowollers < vlogger.Value.Count && mostFamousVloggerFollowed > numberOfFollowedVloggers)
                    {
                        mostFamousVloggerFowollers = vlogger.Value.Count;
                        mostFamousVloggerFollowed = numberOfFollowedVloggers;
                        mostFamousVlogger = vlogger.Key;
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            Console.WriteLine($"1. {mostFamousVlogger} : {mostFamousVloggerFowollers} followers, {mostFamousVloggerFollowed} following");

            foreach (var listOfFollowers in vloggers[mostFamousVlogger].Select(v => v.Value))
            {
                foreach (string follower in listOfFollowers.OrderBy(f => f))
                {
                    Console.WriteLine($"* {follower}");
                }
            }

            vloggers.Remove(mostFamousVlogger);

            int numberOfVlogger = 2;

            //foreach (string vlogger in vloggers.Keys)
            //{
            //    foreach (int numberOfFollowed in vloggers[vlogger].Select(v => v.Key))
            //    {
            //        Console.WriteLine($"{numberOfVlogger}. {vlogger} : {vloggers[vlogger][numberOfFollowed].Count} followers, {numberOfFollowed} following");
            //    }

            //    numberOfVlogger++;
            //}

            foreach (var vlogger in vloggers.OrderBy(v=>v.Value.Values.Count).ThenBy(v=>v.Value.Keys.Count))
            {
                foreach (int numberOfFollowed in vloggers[vlogger.Key].Select(v => v.Key))
                {
                    Console.WriteLine($"{numberOfVlogger}. {vlogger} : {vloggers[vlogger.Key][numberOfFollowed].Count} followers, {numberOfFollowed} following");
                }

                numberOfVlogger++;
            }
        }
    }
}
