using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string[] command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                try
                {
                    string action = command[0];
                    string teamName = command[1];

                    if (action == "Team")
                    {
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if (action == "Add")
                    {
                        string playerName = command[2];
                        int endurance = int.Parse(command[3]);
                        int sprint = int.Parse(command[4]);
                        int dribble = int.Parse(command[5]);
                        int passing = int.Parse(command[6]);
                        int shooting = int.Parse(command[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        if (teams.Select(t => t.Name).Contains(teamName))
                        {
                            teams.FirstOrDefault(t => t.Name == teamName).AddPlayer(player);
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                    else if (action == "Remove")
                    {
                        string playerName = command[2];

                        Team team = teams.FirstOrDefault(t => t.Name == teamName);

                        if (team == null)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            if (team.Players.Select(p => p.PlayerName).Contains(playerName))
                            {
                                team.Remove(playerName);
                            }
                            else
                            {
                                Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                            }
                        }
                    }
                    else if (action == "Rating")
                    {
                        Team team = teams.FirstOrDefault(t => t.Name == teamName);

                        if (team == null)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            Console.WriteLine($"{team.Name} - {team.Rating()} "); 
                        }
                    }

                    command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                }
            }
        }
    }
}
