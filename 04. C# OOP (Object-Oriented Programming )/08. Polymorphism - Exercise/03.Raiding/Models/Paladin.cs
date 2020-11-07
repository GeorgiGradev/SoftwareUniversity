using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.Models
{
    public class Paladin : Hero
    {
        public Paladin(string name, int power) 
            : base(name, power)
        {

        }
        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
