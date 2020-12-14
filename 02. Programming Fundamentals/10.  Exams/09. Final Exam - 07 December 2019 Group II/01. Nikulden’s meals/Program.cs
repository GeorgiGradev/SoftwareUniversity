using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Xml;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string input = string.Empty;
            int count = 0;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] tokens = input.Split("-");
                string command = tokens[0];
                string guest = tokens[1];
                string meal = tokens[2];

                if (command == "Like")
                {
                    if (!dict.ContainsKey(guest))
                    {
                        dict.Add(guest, new List<string>());
                    }
                    if (!dict[guest].Contains(meal))
                    {
                        dict[guest].Add(meal);
                    }
                }
                else if (command == "Unlike")
                {
                    if (dict.ContainsKey(guest) && dict[guest].Contains(meal))
                    {
                        dict[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        count++;
                    }
                    else if (!dict.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (dict.ContainsKey(guest) && !dict[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}
