using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string companyName = string.Empty;
            string ID = string.Empty;

            while (command != "End")
            {
                List<string> input = command
                    .Split(" -> ")
                    .ToList();
                companyName = input[0];
                ID = input[1];

                if (!dict.ContainsKey(companyName))
                {
                    dict.Add(companyName, new List<string>());
                    dict[companyName].Add(ID);
                }
                else if (dict.ContainsKey(companyName))
                {
                    if (!dict[companyName].Contains(ID))
                    {
                        dict[companyName].Add(ID);
                    }
                }
                command = Console.ReadLine();
                }
                foreach (var item in dict.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key}");

                    foreach (var name in item.Value)
                    {
                        Console.WriteLine($"-- {name}");
                    }
                }
            }
        }
    }
