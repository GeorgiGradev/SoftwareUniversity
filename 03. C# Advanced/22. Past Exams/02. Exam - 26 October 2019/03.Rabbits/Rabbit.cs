using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace Rabbits
{
    public class Rabbit
    {
        private bool available = true;

        public Rabbit(string name, string species)
        {
            Name = name;
            Species = species;
            Available = available;
        }

        public string Name { get; set; }
        public string Species { get; set; }
        public bool Available { get => available; set => available = value; }

        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }
    }
}
