using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            string input = string.Empty;
             
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] tokens = input.Split("||");
                string town = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (!dict.ContainsKey(town))
                {
                    dict.Add(town, new List<int>() { 0, 0});
                }
                dict[town][0] += population;
                dict[town][1] += gold;
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split("=>");
                string command = tokens[0];
                string town = tokens[1];

                if (command == "Plunder")
                {
                    int peopleKilled = int.Parse(tokens[2]);
                    int goldStolen = int.Parse(tokens[3]);

                    dict[town][0] -= peopleKilled;
                    dict[town][1] -= goldStolen;

                    if (dict[town][0] > 0 && dict[town][1] > 0)
                    {
                        Console.WriteLine($"{town} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                    }
                    else
                    {
                        Console.WriteLine($"{town} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                        Console.WriteLine($"{town} has been wiped off the map!");
                        dict.Remove(town);
                    }
                }
                else if (command == "Prosper")
                {
                    int goldAdded = int.Parse(tokens[2]);
                    if (goldAdded < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        dict[town][1] += goldAdded;
                        Console.WriteLine($"{goldAdded} gold added to the city treasury. {town} now has {dict[town][1]} gold.");
                    }
                }
            }
            if (dict.Keys.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dict.Keys.Count} wealthy settlements to go to:");
                foreach (var item in dict.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
