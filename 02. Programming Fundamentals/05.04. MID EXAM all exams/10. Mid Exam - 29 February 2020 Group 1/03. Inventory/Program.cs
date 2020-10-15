using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = Console.ReadLine(); 

            while (command != "Craft!")
            {
                string[] tokens = command
                    .Split(" - ")
                    .ToArray();

                if (tokens[0] == "Collect")
                {
                    string item = tokens[1];
                    if (!input.Contains(item))
                    {
                        input.Add(item);
                    }
                }
                else if (tokens[0] == "Drop")
                {
                    string item = tokens[1];
                    if (input.Contains(item))
                    {
                        input.Remove(item);
                    }
                }
                else if (tokens[0] == "Combine Items")
                {
                    string[] items = tokens[1]
                        .Split(':')
                        .ToArray();
                    string oldItem = items[0];
                    string newItem = items[1];
                    if (input.Contains(oldItem))
                    {
                        int indexOldItem = input.IndexOf(oldItem);
                        input.Insert(indexOldItem + 1, newItem);
                    }
                }
                else if (tokens[0] == "Renew")
                {
                    string item = tokens[1];
                    if (input.Contains(item))
                    {
                        input.Remove(item);
                        input.Add(item);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
