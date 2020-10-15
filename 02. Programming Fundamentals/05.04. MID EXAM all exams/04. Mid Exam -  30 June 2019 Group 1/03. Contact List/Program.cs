using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Contact_List
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
                string command = tokens[0];

                if (command == "Add")
                {
                    string contact = tokens[1];
                    int index = int.Parse(tokens[2]);
                    if (!input.Contains(contact))
                    {
                        input.Add(contact);
                    }
                    else if (input.Contains(contact))
                    {
                        if (input.Count - 1 >= index && index >= 0)
                        {
                            input.Insert(index, contact);
                        }
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input.RemoveAt(index);
                    }
                }
                else if (command == "Export")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int count = int.Parse(tokens[2]);

                    if (input.Count - 1 >= startIndex)
                    {
                        if (startIndex + count <= input.Count - 1 && startIndex + count >= 0)
                        {
                            for (int k = startIndex; k < startIndex + count; k++)
                            {
                                Console.Write($"{input[k]} ");
                            }
                            Console.WriteLine();
                        }
                        else if (startIndex + count > input.Count - 1)
                        {
                            for (int k = startIndex; k < input.Count; k++)
                            {
                                Console.Write($"{input[k]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else if (command == "Print")
                {
                    string normalReversed = tokens[1];

                    if (normalReversed == "Normal")
                    {
                        Console.WriteLine($"Contacts: {String.Join(" ", input)}");
                    }
                    else if (normalReversed == "Reversed")
                    {
                        List<string> reversed = input.ToList();
                        reversed.Reverse();
                        Console.WriteLine($"Contacts: {String.Join(" ", reversed)}");
                    }
                    break;
                }
            }
        }
    }
}
