using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                if (tokens[0] == "Move")
                {
                    int index = int.Parse(tokens[2]);
                    
                    if (tokens[1] == "Left")
                    {
                        if (index - 1 >= 0 && index <= input.Count - 1)
                        {
                            string toMove = input[index];
                            input.RemoveAt(index); 
                            input.Insert(index - 1, toMove);
                        }
                    }
                    else if (tokens[1] == "Right")
                    {
                        if (index + 1 <= input.Count - 1 && index >= 0)
                        {
                            string toMove = input[index];
                            input.RemoveAt(index);
                            input.Insert(index + 1, toMove);
                        }
                    }
                }
                else if (tokens[0] == "Check")
                {
                    if (tokens[1] == "Even")
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write($"{input[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (tokens[1] == "Odd")
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write($"{input[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You crafted {string.Join("", input)}!");

        }
    }
}
