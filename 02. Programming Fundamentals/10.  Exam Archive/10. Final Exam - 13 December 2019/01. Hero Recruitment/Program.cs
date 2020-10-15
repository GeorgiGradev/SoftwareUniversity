using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace _01._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string heroName = tokens[1];

                if (command == "Enroll")
                {
                    if (!dict.ContainsKey(heroName))
                    {
                        dict.Add(heroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (command == "Learn")
                {
                    string spellName = tokens[2];
                    if (dict.ContainsKey(heroName) && !dict[heroName].Contains(spellName))
                    {
                        dict[heroName].Add(spellName);
                    }
                    else if (!dict.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (dict.ContainsKey(heroName) && dict[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} has already learnt {spellName}.");
                    }
                }
                else if (command == "Unlearn")
                {
                    string spellName = tokens[2];
                    if (dict.ContainsKey(heroName) && !dict[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} doesn't know {spellName}.");
                    }
                    else if (!dict.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (dict.ContainsKey(heroName) && dict[heroName].Contains(spellName))
                    {
                        dict[heroName].Remove(spellName);
                    }
                }
            }
            Console.WriteLine("Heroes:");
            foreach (var item in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
