using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.Models
{
    public class Warrior : Hero
    {
        public Warrior(string name, int power) 
            : base(name, power)
        {

        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
