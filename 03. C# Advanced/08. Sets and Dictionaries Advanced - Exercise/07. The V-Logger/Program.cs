using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictFollowing = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> dictFollowedBy = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine(); 
                if (input == "Statistics")
                {
                    break;
                }
                else
                {
                    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string vlogger = tokens[0];
                    string command = tokens[1];
                    string followed = tokens[2];

                    if (command == "joined")
                    {
                        if (!dictFollowing.ContainsKey(vlogger))
                        {
                            dictFollowing.Add(vlogger, new List<string>());
                            dictFollowedBy.Add(vlogger, new List<string>());
                        }
                    }
                    else if (command == "followed")
                    {
                        if (dictFollowing.ContainsKey(vlogger) && dictFollowedBy.ContainsKey(followed))
                        {
                            if (vlogger != followed && !dictFollowedBy[followed].Contains(vlogger))
                            {
                                dictFollowedBy[followed].Add(vlogger);
                                dictFollowing[vlogger].Add(followed);
                            }
                        }
                    }
                }
            }
            dictFollowedBy = dictFollowedBy.OrderByDescending(x => x.Value.Count())
                .ThenBy(x => dictFollowing[x.Key].Count()).ToDictionary(a => a.Key, b => b.Value);

            int vloggersCount = dictFollowedBy.Count();
            Console.WriteLine($"The V-Logger has a total of {vloggersCount} vloggers in its logs.");
            int count = 0;
            foreach (var (key, value) in dictFollowedBy)
            {
                foreach (var (key1, value1) in dictFollowing)
                {
                    if (key == key1)
                    {
                        count++;
                        if (count == 1)
                        {
                            Console.WriteLine($"{count}. {key} : {value.Count} followers, {value1.Count} following");
                            foreach (var item in value.OrderBy(x=>x))
                            {
                                Console.WriteLine($"*  {item}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{count}. {key} : {value.Count} followers, {value1.Count} following");
                        }
                    }
                }
            }
        }
    }
}
