using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private readonly ICollection<IPlayer> players;
        private readonly IPlayer mainPLayer;
        private readonly Queue<IGun> guns;

        public Controller()
        {
            this.mainPLayer = new MainPlayer();
            this.guns = new Queue<IGun>();
            this.players = new List<IPlayer>();
        }

        public string AddPlayer(string name)
        {
            var player = new CivilPlayer(name);
            players.Add(player);
            return $"Successfully added civil player: {name}!";
        }

        public string AddGun(string type, string name)
        {
            if (type == "Pistol")
            {
                IGun gun = new Pistol(name);
                guns.Enqueue(gun);
                return $"Successfully added {name} of type: {type}";
            }
            else if (type == "Rifle")
            {
                IGun gun = new Rifle(name);
                guns.Enqueue(gun);
                return $"Successfully added {name} of type: {type}";
            }
            return "Invalid gun type!";
        }

        public string AddGunToPlayer(string name)
        {
            if (guns.Count == 0)
            {
                return "There are no guns in the queue!";
            }
            else
            {
                var currentGun = guns.Peek();
                if (name == "Vercetti")
                {
                    mainPLayer.GunRepository.Add(guns.Dequeue());
                    return $"Successfully added {currentGun} to the Main Player: Tommy Vercetti";
                }
                else if (players.Any(x => x.Name == name))
                {
                    var player = players.FirstOrDefault(x => x.Name == name);
                    player.GunRepository.Add(guns.Dequeue());
                    return $"Successfully added {currentGun.Name} to the Civil Player: {player.Name}";
                }
            }
            return "Civil player with that name doesn't exists!";
        }

        public string Fight()
        {
            int civilPlayersCountAtBeginning = players.Count;
            GangNeighbourhood gangNeighbourhood = new GangNeighbourhood();
            gangNeighbourhood.Action(mainPLayer, players);
            if (mainPLayer.IsAlive && civilPlayersCountAtBeginning == players.Count)
            {
                return "Everything is okay!";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A fight happend:")
                .AppendLine($"Tommy live points: {mainPLayer.LifePoints}!")
                .AppendLine($"Tommy has killed: {civilPlayersCountAtBeginning - players.Count} players!")
                .AppendLine($"Left Civil Players: {players.Count}!");
            return sb.ToString().TrimEnd();
        }
    }
}
