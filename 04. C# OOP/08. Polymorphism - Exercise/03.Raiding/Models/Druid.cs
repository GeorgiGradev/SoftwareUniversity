using _03.Raiding.Models.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.Models
{
    public class Druid : Hero
    {
        private string name;
        public Druid(string name, int power)
            : base(name, power)
        {
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
