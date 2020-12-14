using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _01._Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input.Split("=");
                string command = tokens[0];
                if (command == "Add")
                {
                    string userName = tokens[1];
                    int sent = int.Parse(tokens[2]);
                    int received = int.Parse(tokens[3]);
                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new List<int> { sent, received });
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Message")
                {
                    string sender = tokens[1];
                    string receiver = tokens[2];

                    if (dict.ContainsKey(sender) && dict.ContainsKey(receiver))
                    {
                        if (dict[sender][0] + dict[sender][1] + 1 < capacity)
                        {
                            dict[sender][0] += 1;
                        }
                        else
                        {
                            dict.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (dict[receiver][0] + dict[receiver][1] + 1 < capacity)
                        {
                            dict[receiver][1] += 1;
                        }
                        else
                        {
                            dict.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }

                }
                else if (command == "Empty")
                {
                    string userName = tokens[1];
                    if(dict.ContainsKey(userName))
                    {
                        dict.Remove(userName);
                    }
                    if (userName == "All")
                    {
                        dict.Clear();
                    }
                }
            }
            Console.WriteLine($"Users count: {dict.Keys.Count}");
            foreach (var item in dict.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Sum()}");
            }
        }
    }
}
