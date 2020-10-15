using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Practice_Sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input
                    .Split("->");

                string command = tokens[0];

                if (command == "Add")
                {
                    string road = tokens[1];
                    string racer = tokens[2];
                    if (!dict.ContainsKey(road))
                    {
                        dict.Add(road, new List<string>());
                    }
                    dict[road].Add(racer);
                }
                else if (command == "Move")
                {
                    string currentRoad = tokens[1];
                    string racer = tokens[2];
                    string nextRoad = tokens[3];
                    if (dict[currentRoad].Contains(racer))
                    {
                        dict[currentRoad].Remove(racer);
                        dict[nextRoad].Add(racer);
                    }
                }
                else if (command == "Close")
                {
                    string road = tokens[1];
                    dict.Remove(road);
                }
            }
            Console.WriteLine("Practice sessions:");
            foreach (var item in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var racer in item.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }

        }
    }
}
