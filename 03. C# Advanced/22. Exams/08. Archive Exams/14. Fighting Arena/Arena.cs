using System.Linq;
using System.Collections.Generic;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }

        public int Count => this.gladiators.Count;

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator); //TODO  - >•	The names of the gladiators will be always unique
        }

        public void Remove(string name)
        {
            Gladiator gladiator = gladiators.FirstOrDefault(x => x.Name == name);

            gladiators.Remove(gladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator gladiatorWithHighestStatPower = null;

            int maxStat = int.MinValue;

            foreach (var currentGladiator in gladiators)
            {
                if (currentGladiator.GetStatPower() > maxStat)
                {
                    maxStat = currentGladiator.GetStatPower();
                    gladiatorWithHighestStatPower = currentGladiator;
                }
            }

            return gladiatorWithHighestStatPower;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator gladiatorWithHighestWeaponPower = null;

            int maxWeponPower = int.MinValue;

            foreach (var currentGladiator in gladiators)
            {
                if (currentGladiator.GetWeaponPower() > maxWeponPower)
                {
                    maxWeponPower = currentGladiator.GetWeaponPower();
                    gladiatorWithHighestWeaponPower = currentGladiator;
                }
            }

            return gladiatorWithHighestWeaponPower;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator strongestGladiator = null;

            int maxTotalPower = int.MinValue;

            foreach (var currentGladiator in gladiators)
            {
                if (currentGladiator.GetTotalPower() > maxTotalPower)
                {
                    maxTotalPower = currentGladiator.GetTotalPower();
                    strongestGladiator = currentGladiator;
                }
            }

            return strongestGladiator;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}
