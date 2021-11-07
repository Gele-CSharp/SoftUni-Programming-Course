using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private List<Player> players;
        private string name;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public List<Player> Players => players;

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void Remove(string playerName)
        {
            if (players.Select(p=> p.PlayerName).Contains(playerName))
            {
                Player playerToRemove = players.FirstOrDefault(p => p.PlayerName == playerName);
                players.Remove(playerToRemove);
            }
        }

        public int Rating()
        {
            int totalSkills = 0;

            if (players.Count == 0)
            {
                return 0;
            }

            totalSkills = (int)Math.Round(players.Sum(p => p.Stat) / players.Count * 1.0);

            return totalSkills;
        }
    }
}
