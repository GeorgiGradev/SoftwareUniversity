using _03.Raiding.Models.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.Models
{
    public abstract class Hero : IHero
    {
        public Hero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
        public string Name { get;}
        public int Power { get; }

    }
}
