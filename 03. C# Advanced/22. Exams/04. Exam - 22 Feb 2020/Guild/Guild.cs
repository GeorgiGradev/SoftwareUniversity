using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Guild
{

    public class Guild
    {
        private List<Player> rooster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            rooster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => rooster.Count;


        public void AddPlayer(Player player)
        {
            if (Capacity > rooster.Count)
            {
                rooster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            return rooster.Remove(rooster.FirstOrDefault(x => x.Name == name));
        }
        public void PromotePlayer(string name)
        {
            Player player = rooster.FirstOrDefault(x => x.Name == name);
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            Player player = rooster.FirstOrDefault(x => x.Name == name);
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string @class)
        {
            var kickedPlayers = rooster.FindAll(x => x.Class == @class).ToArray();
            rooster.RemoveAll(x => x.Class == @class);
            return kickedPlayers;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in rooster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
