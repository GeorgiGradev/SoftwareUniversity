using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            data = new List<Hero>();
        }

        //public List<Hero> data { get; set; }


        public int Count => data.Count();

        public void Add(Hero hero)
        {
            data.Add(hero);
        }
        public void Remove(string name)
        {
            var hero = data.FirstOrDefault(x => x.Name == name);
            data.Remove(hero);
        }
        public Hero GetHeroWithHighestStrength()
        {
            var hero = data.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
            return hero;
        }
        public Hero GetHeroWithHighestAbility()
        {
            var hero = data.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
            return hero;
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            var hero = data.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
            return hero;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in data)
            {
                sb.AppendLine($"Hero: {item.Name} – {item.Level}lvl");
                sb.AppendLine($"Item:");
                sb.AppendLine($"  * Strength: {item.Item.Strength}");
                sb.AppendLine($"  * Ability: {item.Item.Ability}");
                sb.AppendLine($"  * Intelligence: {item.Item.Intelligence}");
            }
            return sb.ToString(); 
        }

    }
}
