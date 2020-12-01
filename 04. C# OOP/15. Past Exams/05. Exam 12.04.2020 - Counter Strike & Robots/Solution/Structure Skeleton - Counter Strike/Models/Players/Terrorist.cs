namespace CounterStrike.Models.Players
{
    using CounterStrike.Models.Guns.Contracts;
    using CounterStrike.Models.Players.Contracts;

    public class Terrorist : Player, IPlayer
    {
        public Terrorist(string username, int health, int armor, IGun gun) 
            : base(username, health, armor, gun)
        {
        }
    }
}
