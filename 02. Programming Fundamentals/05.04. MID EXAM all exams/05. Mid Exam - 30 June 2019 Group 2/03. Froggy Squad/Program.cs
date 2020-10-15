using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (tokens[0] == "Join")
                {
                    input.Add(tokens[1]);
                }
                else if (tokens[0] == "Jump")
                {
                    int index = int.Parse(tokens[2]);
                    string name = tokens[1];
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input.Insert(index, name);
                    }
                }
                else if (tokens[0] == "Dive")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input.RemoveAt(index);
                    }
                }
                else if (tokens[0] == "First")
                {
                    int count = int.Parse(tokens[1]);
                    if (input.Count > count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"{input[i]} ");
                        }
                        Console.WriteLine();
                    }
                    else if (input.Count <= count)
                    {
                        Console.WriteLine(string.Join(" ", input));
                    }
                }
                else if (tokens[0] == "Last")
                {
                    int count = int.Parse(tokens[1]);
                    if (input.Count > count)
                    {
                        int start = input.Count - count;
                        for (int i = start; i < input.Count; i++)
                        {
                            Console.Write($"{input[i]} ");
                        }
                        Console.WriteLine();
                    }
                    else if (input.Count <= count)
                    {
                        Console.WriteLine(string.Join(" ", input));
                    }
                }
                else if (tokens[0] == "Print")
                {
                    if (tokens[1] == "Normal")
                    {
                        Console.WriteLine($"Frogs: {string.Join(" ", input)}");
                    }
                    else if (tokens[1] == "Reversed")
                    {
                        input.Reverse();
                        Console.WriteLine($"Frogs: {string.Join(" ", input)}");
                    }
                    break;
                }
            }
        }
    }
}
