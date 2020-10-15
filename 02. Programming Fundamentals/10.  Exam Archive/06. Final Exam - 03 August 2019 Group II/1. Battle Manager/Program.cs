using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace _1._Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Results")
            {
                string[] tokens = input.Split(":");
                string command = tokens[0];

                if (command == "Add")
                {
                    string name = tokens[1];
                    int health = int.Parse(tokens[2]);
                    int energy = int.Parse(tokens[3]);

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<int>() {health, energy});
                    }
                    else
                    {
                        dict[name][0] += health;
                    }
                }
                else if (command == "Attack")
                {
                    string attackerName = tokens[1];
                    string defenderName = tokens[2];
                    int damage = int.Parse(tokens[3]);

                    if (dict.ContainsKey(attackerName) && dict.ContainsKey(defenderName))
                    {
                        dict[defenderName][0] -= damage;
                        if (dict[defenderName][0] <= 0)
                        {
                            dict.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }
                        dict[attackerName][1] -= 1;
                        if (dict[attackerName][1] == 0)
                        {
                            dict.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }
                }
                else if (command == "Delete")
                {
                    string toRemove = tokens[1];
                    if (toRemove == "All")
                    {
                        dict.Clear();
                    }
                    else
                    {
                        if (dict.ContainsKey(toRemove))
                        {
                            dict.Remove(toRemove);
                        }
                    }
                }
            }
            Console.WriteLine($"People count: {dict.Keys.Count()}");
            foreach (var item in dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
            }
        }
    }
}
