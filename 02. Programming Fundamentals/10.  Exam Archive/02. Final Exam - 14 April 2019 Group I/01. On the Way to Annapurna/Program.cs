using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._On_the_Way_to_Annapurna
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
                string store = tokens[1];

                if (command == "Add")
                {
                    string item = tokens[2];
                    string[] itemTokens = item.Split(",");
                    if (!dict.ContainsKey(store))
                    {
                        dict.Add(store, new List<string>());
                    }
                    for (int i = 0; i < itemTokens.Length; i++)
                    {
                        dict[store].Add(itemTokens[i]);
                    }
                }
                else if (command == "Remove")
                {
                    if (dict.ContainsKey(store))
                    {
                        dict.Remove(store);
                    }
                }
            }
            Console.WriteLine("Stores list:");
            foreach (var store in dict.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
            {
                Console.WriteLine(store.Key);
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
