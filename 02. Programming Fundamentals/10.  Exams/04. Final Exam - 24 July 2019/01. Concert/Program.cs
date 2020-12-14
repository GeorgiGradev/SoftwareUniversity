using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] tokens = input.Split("; ");
                string command = tokens[0];
                if (command == "Add")
                {
                    string band = tokens[1];
                    string[] membersToAdd = tokens[2].Split(", ");
                    if (!dict.ContainsKey(band))
                    {
                        dict.Add(band, new List<string>());
                    }
                    for (int i = 0; i < membersToAdd.Length; i++)
                    {
                        if (!dict[band].Contains(membersToAdd[i]))
                        {
                            dict[band].Add(membersToAdd[i]);
                        }
                    }
                }
                else if (command == "Play")
                {
                    string band = tokens[1];
                    int time = int.Parse(tokens[2]);
                    if (!bandTime.ContainsKey(band))
                    {
                        bandTime.Add(band, 0);
                    }
                    bandTime[band] += time;
                }
            }
            int totalTime = bandTime.Values.Sum();
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var item in bandTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            string bandToPrint = Console.ReadLine();
            foreach (var item in dict)
            {
                if (bandToPrint == item.Key)
                {
                    Console.WriteLine(item.Key);
                    foreach (var members in item.Value)
                    {
                        Console.WriteLine($"=> {members}");
                    }
                }
            }
        }
    }
}
