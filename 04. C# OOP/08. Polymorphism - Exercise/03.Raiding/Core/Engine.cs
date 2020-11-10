using _03.Raiding.Core.Contracts;
using _03.Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.Core
{
    public class Engine : IEngine
    {
        public const int druidPower = 80;
        public const int paladinPower = 100;
        public const int roguePower = 80;
        public const int warriorPower = 100;
        public void Run()
        {
            int amountOfHeroesToCreate = int.Parse(Console.ReadLine());
            Hero hero = null;
            List<Hero> heroes = new List<Hero>();
            int counter = 0;

            while (counter != amountOfHeroesToCreate)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid")
                {
                    hero = new Druid(heroName, druidPower);
                    heroes.Add(hero);
                    counter++;
                }
                else if (heroType == "Paladin")
                {
                    hero = new Paladin(heroName, paladinPower);
                    heroes.Add(hero);
                    counter++;
                }
                else if (heroType == "Rogue")
                {
                    hero = new Rogue(heroName, roguePower);
                    heroes.Add(hero);
                    counter++;
                }
                else if (heroType == "Warrior")
                {
                    hero = new Warrior(heroName, warriorPower);
                    heroes.Add(hero);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }

            }
            int bossPower = int.Parse(Console.ReadLine());
            int powerSum = 0;

            foreach (var item in heroes)
            {
                Console.WriteLine(item.ToString());
                powerSum += item.Power;
            }
             
            if (powerSum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
