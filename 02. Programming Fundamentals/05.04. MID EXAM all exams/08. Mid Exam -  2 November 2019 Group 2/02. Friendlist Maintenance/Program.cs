using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = Console.ReadLine();
            int blacklisted = 0;
            int lost = 0;

            while (command != "Report")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                if (tokens[0] == "Blacklist")
                {
                    string name = tokens[1];
                    if (input.Contains(name))
                    {
                        int index = input.IndexOf(name);
                        input[index] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                        blacklisted++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (tokens[0] == "Error")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        if (input[index] != "Blacklisted" && input[index] != "Lost")
                        {
                            string name = input[index];
                            input[index] = "Lost";
                            Console.WriteLine($"{name} was lost due to an error.");
                            lost++;
                        }
                    }
                }
                else if (tokens[0] == "Change")
                {
                    int index = int.Parse(tokens[1]);
                    string newName = tokens[2];
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        string name = input[index];
                        input[index] = newName;
                        Console.WriteLine($"{name} changed his username to {newName}.");
                    }
                }

                command = Console.ReadLine();
            }
            //int blacklisted = 0;
            //int lost = 0;
            //foreach (var item in input)
            //{
            //    if (item == "Blacklisted")
            //    {
            //        blacklisted++;
            //    }
            //    else if (item == "Lost")
            //    {
            //        lost++;
            //    }
            //}
            Console.WriteLine($"Blacklisted names: {blacklisted}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
