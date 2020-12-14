using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _01._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string heroName = tokens[0];
                int HP = int.Parse(tokens[1]);
                int MP = int.Parse(tokens[2]);

                if (!dict.ContainsKey(heroName))
                {
                    dict.Add(heroName, new List<int>() { 0, 0 });
                }
                dict[heroName][0] += HP;
                dict[heroName][1] += MP;
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];
                string heroName = tokens[1];

                if (command == "CastSpell")
                {
                    int MPlost = int.Parse(tokens[2]);
                    string spellName = tokens[3];
                    if (dict[heroName][1] - MPlost >= 0)
                    {
                        dict[heroName][1] -= MPlost;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {dict[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];
                    if (dict[heroName][0] - damage > 0)
                    {
                        dict[heroName][0] -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {dict[heroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        dict.Remove(heroName);
                    }
                }
                else if (command == "Recharge")
                {
                    int MPrecharged = int.Parse(tokens[2]);
                    if (dict[heroName][1] + MPrecharged > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - dict[heroName][1]} MP!");
                        dict[heroName][1] = 200;
                    }
                    else
                    {
                        dict[heroName][1] += MPrecharged;
                        Console.WriteLine($"{heroName} recharged for {MPrecharged} MP!");
                    }
                }
                else if (command == "Heal")
                {
                    int HPrecharged = int.Parse(tokens[2]);
                    if (dict[heroName][0] + HPrecharged > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - dict[heroName][0]} HP!");
                        dict[heroName][0] = 100;
                    }
                    else
                    {
                        dict[heroName][0] += HPrecharged;
                        Console.WriteLine($"{heroName} healed for {HPrecharged} HP!");
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");
            }
        }
    }
}
