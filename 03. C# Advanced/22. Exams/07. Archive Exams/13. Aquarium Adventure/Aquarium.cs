using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace AquariumAdventure
{
    public class Aquarium
    {
        private List<Fish> fishInPool;

        public Aquarium(string name, int capacity, int size)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
            this.fishInPool = new List<Fish>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Size { get; set; }

        public void Add(Fish fish)
        {
            if (fishInPool.Count + 1 <= Capacity && !this.fishInPool.Any(x => x.Name == fish.Name))//TODO
            {
                fishInPool.Add(fish);
            }
        }

        public bool Remove(string name)
        {
            var targetFish = fishInPool.FirstOrDefault(x => x.Name == name);

            if (targetFish != null)
            {
                fishInPool.Remove(targetFish);
                return true;
            }

            return false;
        }

        public Fish FindFish(string name)
        {
            Fish fish = fishInPool.FirstOrDefault(x => x.Name == name);

            return fish;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");

            foreach (var currentFish in this.fishInPool)
            {
                stringBuilder.AppendLine(currentFish.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
