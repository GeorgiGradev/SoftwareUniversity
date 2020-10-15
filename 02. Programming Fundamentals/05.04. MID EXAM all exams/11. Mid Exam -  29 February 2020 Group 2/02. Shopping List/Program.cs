using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('!')
                .ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                if (tokens[0] == "Urgent")
                {
                    string item = tokens[1];
                    if (!input.Contains(item))
                    {
                        input.Insert(0, item);
                    }
                }
                else if (tokens[0] == "Unnecessary")
                {
                    string item = tokens[1];
                    if (input.Contains(item))
                    {
                        input.Remove(item);
                    }
                }
                else if (tokens[0] == "Correct")
                {
                    string oldItem = tokens[1];
                    string newItem = tokens[2];
                    if (input.Contains(oldItem))
                    {
                        int index = input.IndexOf(oldItem);
                        input[index] = newItem;
                    }
                }
                else if (tokens[0] == "Rearrange")
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
