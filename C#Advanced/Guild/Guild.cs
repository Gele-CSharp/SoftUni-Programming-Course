using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> players;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            players = new List<Player>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count { get; private set; }

        public void AddPlayer(Player player)
        {
            if (players.Count < Capacity)
            {
                players.Add(player);
                Count++;
            }
        }

        public bool RemovePlayer(string name)
        {
            bool isRemoved = false;

            if (players.Select(p=> p.Name).Contains(name))
            {
                Player playerToRemove = players.Where(p => p.Name == name).FirstOrDefault();
                players.Remove(playerToRemove);
                Count--;
                isRemoved = true;
            }

            return isRemoved;
        }

        public void PromotePlayer(string name)
        {
            if (players.Select(p=> p.Name).Contains(name))
            {
                Player playerToPromote = players.Where(p => p.Name == name).FirstOrDefault();
                playerToPromote.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            if (players.Select(p => p.Name).Contains(name))
            {
                Player playerToDemote = players.Where(p => p.Name == name).FirstOrDefault();
                playerToDemote.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] kickedPlayers = players.Where(p => p.Class == @class).ToArray();
            players = players.Where(p => p.Class != @class).ToList();
            Count -= kickedPlayers.Length;
            return kickedPlayers;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {Name}");

            foreach (var player in players)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
