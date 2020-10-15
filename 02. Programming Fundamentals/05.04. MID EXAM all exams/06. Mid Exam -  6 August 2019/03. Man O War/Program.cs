using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();
            List<int> warShip = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string retire = Console.ReadLine();

            while (retire != "Retire")
            {
                string[] tokens = retire
                    .Split()
                    .ToArray();

                if (tokens[0] == "Fire") // pirate ship attacks the war ship
                {
                    int index = int.Parse(tokens[1]);
                    int damage = int.Parse(tokens[2]);
                    if (warShip.Count - 1 >= index && index >= 0)
                    {
                        int section = warShip[index] - damage;
                        if (section <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                        else
                        {
                            warShip.RemoveAt(index);
                            warShip.Insert(index, section);
                        }
                    }
                }
                else if (tokens[0] == "Defend") // war ship attacks the pirate ship
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int damage = int.Parse(tokens[3]);
                    if (startIndex >= 0 && startIndex <= endIndex && pirateShip.Count - 1 >= endIndex)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] = pirateShip[i] - damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (tokens[0] == "Repair") // repair a section of the pirate ship 
                {
                    int index = int.Parse(tokens[1]);
                    int health = int.Parse(tokens[2]);
                    if (pirateShip.Count - 1 >= index && index >= 0)
                    {
                        if (pirateShip[index] + health < maxHealth)
                        {
                            pirateShip[index] += health;
                        }
                        else if (pirateShip[index] + health >= maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (tokens[0] == "Status") //prints count of sections of the pirate ship that needs repair
                {
                    int sections = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if ((pirateShip[i] / (double)maxHealth * 100) < 20)
                        {
                            sections++;
                        }
                    }
                    Console.WriteLine($"{sections} sections need repair.");
                }

                retire = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
