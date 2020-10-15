using System;
using System.Collections.Generic;

namespace _01._Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] tokens = input.Split(":");
                string command = tokens[0];
                string userName = tokens[1];

                if (command == "New follower")
                {
                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new List<int> { 0, 0 });
                    }
                }
                else if (command == "Like")
                {
                    int count = int.Parse(tokens[2]);
                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new List<int> { count, 0 });
                    }
                    else
                    {
                        dict[userName][0] += count;
                    }
                }
                else if (command == "Comment")
                {
                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new List<int> { 0, 1 });
                    }
                    else
                    {
                        dict[userName][1] += 1;
                    }
                }
                else if (command == "Blocked")
                {
                    if (dict.ContainsKey(userName))
                    {
                        dict.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} doesn't exist.");
                    }
                }
            }
            Console.WriteLine($"{dict.Keys.Count} followers");
            foreach (var item in dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Sum()}");
            }
        }
    }
}
