using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(':')
                .ToList();
            List<string> output = new List<string>();
            string command = Console.ReadLine();

            while (command != "Ready")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                if (tokens[0] == "Add")
                {
                    if (input.Contains(tokens[1]))
                    {
                        output.Add(tokens[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    string cardName = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (input.Contains(cardName) && index >= 0 && output.Count - 1 >= index)
                    {
                        output.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }

                else if (tokens[0] == "Remove")
                {
                    if (output.Contains(tokens[1]))
                    {
                        output.Remove(tokens[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (tokens[0] == "Swap")
                {
                    string cardName1 = tokens[1];
                    string cardName2 = tokens[2];
                    int index1 = output.IndexOf(cardName1);
                    int index2 = output.IndexOf(cardName2);
                    string temp = output[index1];
                    output[index1] = output[index2];
                    output[index2] = temp;

                }
                else if (tokens[0] == "Shuffle")
                {
                    output.Reverse();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
