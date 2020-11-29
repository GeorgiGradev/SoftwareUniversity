namespace CounterStrike.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CounterStrike.Core.Contracts;
    using CounterStrike.Models.Guns;
    using CounterStrike.Models.Guns.Contracts;
    using CounterStrike.Models.Maps;
    using CounterStrike.Models.Maps.Contracts;
    using CounterStrike.Models.Players;
    using CounterStrike.Models.Players.Contracts;
    using CounterStrike.Repositories;
    using CounterStrike.Repositories.Contracts;
    using CounterStrike.Utilities.Messages;

    public class Controller : IController
    {
        private readonly IRepository<IGun> guns;
        private readonly IRepository<IPlayer> players;  // TODO  да се смени с PlayerRepository players просто за проба
        private readonly IMap map;

        public Controller()
        {
            this.players = new PlayerRepository();
            this.guns = new GunRepository();
            this.map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            IGun gun;
            if (type == nameof(Pistol))
            {
                gun = new Pistol(name, bulletsCount);
            }
            else if (type == nameof(Rifle))
            {
                gun = new Rifle(name, bulletsCount);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }
            guns.Add(gun);
            return string.Format(OutputMessages.SuccessfullyAddedGun, name);
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            var currentGun = this.guns.FindByName(gunName);
            if (currentGun == null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }
            IPlayer player;
            if (type == "Terrorist")
            {
                player = new Terrorist(username, health, armor, currentGun);
            }
            else if (type == "CounterTerrorist")
            {
                player = new CounterTerrorist(username, health, armor, currentGun);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }
            players.Add(player);
            return string.Format(OutputMessages.SuccessfullyAddedPlayer, username);
        }
        public string StartGame()
        {
            //var alivePlayers = this.players.Models.Where(x => x.IsAlive).ToList();
            return map.Start(players.Models.ToList());
            ;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var player in players.Models.
                OrderBy(x=>x.GetType().Name).
                ThenByDescending(x=>x.Health).
                ThenBy(x=>x.Username))
            {
                sb.AppendLine($"{player.GetType().Name}: {player.Username}");
                sb.AppendLine($"--Health: {player.Health}");
                sb.AppendLine($"--Armor: {player.Armor}");
                sb.AppendLine($"--Gun: {player.Gun.Name}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
