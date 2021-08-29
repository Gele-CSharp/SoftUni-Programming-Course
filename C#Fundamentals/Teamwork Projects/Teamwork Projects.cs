using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>(numberOfTeams);

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] teamInfo = Console.ReadLine().Split('-');
                string creator = teamInfo[0];
                string teamName = teamInfo[1];

                if (teams.Select(x => x.Creator).Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (teams.Select(x=>x.Name).Contains(teamName) == false)
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string[] userInfo = Console.ReadLine()
                                    .Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);

            while (userInfo[0].ToLower() != "end of assignment")
            {
                string userName = userInfo[0];
                string teamName = userInfo[1];
                bool isUserExist = false;


                if (teams.Select(x=>x.Users).Any(x=>x.Contains(userName)) || teams.Select(x=>x.Creator).Contains(userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    isUserExist = true;
                }

                //foreach (Team team in teams)
                //{
                //    if (team.Users.Contains(userName) || team.Creator.Contains(userName))
                //    {
                //        Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                //        isUserExist = true;
                //        break;
                //    }
                //}

                if (teams.Select(x => x.Name).Contains(teamName) && isUserExist == false)
                {
                    int index = teams.FindIndex(x => x.Name == teamName);
                    teams[index].Users.Add(userName);
                }
                else if(teams.Select(x => x.Name).Contains(teamName) == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                userInfo = Console.ReadLine()
                           .Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);
            }

            Team[] teamsToDisband = teams.Where(x => x.Users.Count == 0).ToArray();
            Team[] teamsToPrint = teams.Where(x => x.Users.Count >= 1).ToArray();

            foreach (Team team in teamsToPrint.OrderByDescending(x => x.Users.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var user in team.Users.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teamsToDisband.OrderBy(x => x))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Users = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Users { get; set; }
    }
}
