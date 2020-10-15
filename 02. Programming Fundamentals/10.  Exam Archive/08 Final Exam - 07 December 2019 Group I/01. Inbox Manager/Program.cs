using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input.Split("->");
                string command = tokens[0];
                string userName = tokens[1];

                if (command == "Add")
                {
                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{userName} is already registered");
                    }
                }
                else if (command == "Send")
                {
                    string email = tokens[2];
                    dict[userName].Add(email);
                }
                else if (command == "Delete")
                {
                    if (dict.ContainsKey(userName))
                    {
                        dict.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                }
            }
            Console.WriteLine($"Users count: {dict.Keys.Count}");
            foreach (var item in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var emails in item.Value)
                {
                    Console.WriteLine($" - {emails}");
                }
            }
        }
    }
}
