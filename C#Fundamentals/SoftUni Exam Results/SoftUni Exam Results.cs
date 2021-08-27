using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, Dictionary<string, int>> results  = new Dictionary<string, Dictionary<string, int>>();

            //string[] input = Console.ReadLine().Split('-');

            //while (input[0] != "exam finished")
            //{
            //    string userName = input[0];
            //    string language = input[1];
            //    int points = int.Parse(input[2]);

            //    if (results.ContainsKey(language))
            //    {
            //        results[language].Add(userName, points);
            //    }
            //    else
            //    {
            //        results.Add(language, new Dictionary<string, int>() { { userName, points } });
            //    }

            //    if (input[1] == "banned")
            //    {
            //        string user = results.Select(r => r.Value).Where(r => r.Keys.Contains(userName)).ToString();
            //        results.Values.Where(r => r.ContainsKey(user));


            //    }


            //    input = Console.ReadLine().Split('-');
            //}

            Dictionary<string, List<User>> results = new Dictionary<string, List<User>>();

            string[] input = Console.ReadLine().Split('-');

            while (input[0] != "exam finished")
            {
                if (input[1] != "banned")
                {
                    string userName = input[0];
                    string language = input[1];
                    int points = int.Parse(input[2]);

                    User user = new User(userName);

                    if (results.ContainsKey(language) == false)
                    {
                        results.Add(language, new List<User> { new User(userName, points, 1) });
                    }
                    else
                    {
                        if (results[language].Select(r=> r.Name).Contains(userName))
                        {
                            results[language].Find(r => r.Name == userName).IncreaseNumberOfSubmissions();
                            results[language].Find(r => r.Name == userName).CheckForMaxPoints(points);
                        }
                        else
                        {
                            results[language].Add(new User(userName, points, 1));
                        }
                    }
                }
                else
                {
                    string userName = input[0];

                    foreach (var users in results.Values)
                    {
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users.Select(u=> u.Name).Contains(userName))
                            {
                                users.Find(u => u.Name == userName).BanUser();
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split('-');
            }

            List<User> usersToPrint = new List<User>();
             
            foreach (var users in results.Values)
            {
                foreach (var user in users)
                {
                    if (user.Name.Contains("banned"))
                    {
                        continue;
                    }

                    usersToPrint.Add(user);
                }
            }

            Console.WriteLine("Results:");

            foreach (User user in usersToPrint.OrderByDescending(u=> u.MaxPoints).ThenBy(u=> u.Name))
            {
                Console.WriteLine($"{user.Name} | {user.MaxPoints}");
            }

            Console.WriteLine("Submissions:");

            Dictionary<string, int> submissionsPerLanguge = new Dictionary<string, int>();

            foreach (var language in results)
            {
                int submissions = 0;

                foreach (var submission in language.Value)
                {
                    submissions += submission.NumberOfSubmissions;
                }

                submissionsPerLanguge.Add(language.Key, submissions);
            }

            foreach (var language in submissionsPerLanguge.OrderByDescending(s=> s.Value))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }

    class User
    {
        public User(string name)
        {
            Name = name;
        }

        public User(string name, int maxPoints, int numberOfSubmissions)
        {
            Name = name;
            MaxPoints = maxPoints;
            NumberOfSubmissions = numberOfSubmissions;
        }

        public string Name { get; set; }
        public int MaxPoints { get; set; }
        public int NumberOfSubmissions { get; set; }

        public void BanUser()
        {
            this.Name += "banned";
        }

        public void CheckForMaxPoints(int points)
        {
            if (this.MaxPoints < points)
            {
                this.MaxPoints = points;
            }
        }

        public void IncreaseNumberOfSubmissions()
        {
            this.NumberOfSubmissions++;
        }
    }
}
