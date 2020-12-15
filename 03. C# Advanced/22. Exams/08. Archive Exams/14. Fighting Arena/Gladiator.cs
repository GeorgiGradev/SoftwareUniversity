using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            int statSum =
                this.Stat.Strength +
                this.Stat.Flexibility +
                this.Stat.Agility +
                this.Stat.Skills +
                this.Stat.Intelligence;

            int weponSum =
                this.Weapon.Size +
                this.Weapon.Solidity +
                this.Weapon.Sharpness;

            return statSum + weponSum;
        }

        public int GetWeaponPower()
        {
            return
                this.Weapon.Size +
                this.Weapon.Solidity +
                this.Weapon.Sharpness;

        }

        public int GetStatPower()
        {
            return
                this.Stat.Strength +
                this.Stat.Flexibility +
                this.Stat.Agility +
                this.Stat.Skills +
                this.Stat.Intelligence;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine($"[{this.Name}] - [{GetTotalPower()}]")
                .AppendLine($"  Weapon Power: [{GetWeaponPower()}]")
                .AppendLine($"  Stat Power: [{GetStatPower()}]");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
