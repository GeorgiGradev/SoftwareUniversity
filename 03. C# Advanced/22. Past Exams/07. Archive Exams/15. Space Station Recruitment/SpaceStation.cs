using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Astronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;

        public void Add(Astronaut astronaut)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            var target = this.data.FirstOrDefault(x => x.Name == name);

            if (target != null)
            {
                this.data.Remove(target);
                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut astronaut = null;

            int maxAge = int.MinValue;

            foreach (var item in this.data)
            {
                if (item.Age > maxAge)
                {
                    maxAge = item.Age;
                    astronaut = item;
                }
            }

            return astronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            return this.data.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var astronaut in this.data)
            {
                stringBuilder.AppendLine(astronaut.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }

    }

}
