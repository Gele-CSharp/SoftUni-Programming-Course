using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                string splitter = input.Contains("->") ? "->" : "vs";
                string[] playersInfo = input.Split(new string[] { splitter }, StringSplitOptions.RemoveEmptyEntries);

                if (splitter == "->")
                {
                    string player = playersInfo[0].Trim();
                    string position = playersInfo[1].Trim();
                    int skill = int.Parse(playersInfo[2]);

                    if (players.ContainsKey(player) == false)
                    {
                        players.Add(player, new Dictionary<string, int>() { { position, skill } });
                    }
                    else
                    {
                        if (players[player].ContainsKey(position) == false)
                        {
                            players[player][position] = skill;
                        }
                        else
                        {
                            if (players[player][position] < skill)
                            {
                                players[player][position] = skill;
                            }
                        }
                    }
                }
                else if (splitter == "vs")
                {
                    string firstPlayer = playersInfo[0].Trim();
                    string secondPlayer = playersInfo[1].Trim();
                    
                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        int firstPlayerSkillPoints = players[firstPlayer].Select(p => p.Value).Sum();
                        int secondPlayerSkillPoints = players[secondPlayer].Select(p => p.Value).Sum();

                        foreach (var position in players[firstPlayer])
                        {
                            if (players[secondPlayer].ContainsKey(position.Key))
                            {
                                if (firstPlayerSkillPoints > secondPlayerSkillPoints)
                                {
                                    players.Remove(secondPlayer);
                                }
                                else if (secondPlayerSkillPoints > firstPlayerSkillPoints)
                                {
                                    players.Remove(firstPlayer);
                                }

                                break;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in players.OrderByDescending(p=>p.Value.Values.Sum()).ThenBy(p=>p.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(p=>p.Value).ThenBy(p=>p.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
