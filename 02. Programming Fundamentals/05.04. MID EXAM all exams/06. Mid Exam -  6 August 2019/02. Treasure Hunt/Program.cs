using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            string command = Console.ReadLine();

            while (command != "Yohoho!")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                if (tokens[0] == "Loot")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        if (!input.Contains(tokens[i]))
                        {
                            input.Insert(0, tokens[i]);
                        }
                    }
                }
                else if (tokens[0] == "Drop")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        string perm = input[index];
                        input.RemoveAt(index);
                        input.Add(perm);
                    }
                }
                else if (tokens[0] == "Steal")
                {
                    int count = int.Parse(tokens[1]);
                    List<string> stolenItems = new List<string>();
                    if (input.Count > count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stolenItems.Add(input[input.Count - 1]);
                            input.Remove(input[input.Count - 1]);
                        }
                        stolenItems.Reverse();
                        Console.WriteLine(string.Join(", ", stolenItems));
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ", input));
                        input.Clear();
                    }
                }
                command = Console.ReadLine();
            }
            if (input.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                int lettersCount = 0;
                for (int i = 0; i < input.Count; i++)
                {
                    lettersCount += input[i].Length;
                }
                double averageGain = lettersCount / (double)input.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
        }
    }
}
