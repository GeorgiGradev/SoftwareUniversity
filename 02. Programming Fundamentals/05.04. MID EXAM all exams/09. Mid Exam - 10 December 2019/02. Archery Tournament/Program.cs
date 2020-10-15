using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split('|')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            int points = 0;

            while (command != "Game over")
            {
                string[] tokens = command
                    .Split('@')
                    .ToArray();

                if (tokens[0] == "Shoot Left")
                {
                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);

                    if (index >= 0 && index <= input.Count - 1) // if index is valid
                    {
                        while (length != 0)
                        {

                            if (index > 0) 
                            {
                                index--;
                                length--;
                            }
                            else if (index == 0) 
                            {
                                index = input.Count - 1;
                                length--;
                            }
                        }

                        if (input[index] >= 5) // enough points
                        {
                            input[index] -= 5;
                            points += 5;
                        }
                        else // not enough points
                        {
                            points += input[index];
                            input[index] = 0;
                        }
                    }
                }
                else if (tokens[0] == "Shoot Right")
                {
                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);

                    if (index >= 0 && index <= input.Count - 1) // if index is valid
                    {
                        while (length != 0)
                        {

                            if (index < input.Count - 1)
                            {
                                index++;
                                length--;
                            }
                            else if (index == input.Count - 1)
                            {
                                index = 0;
                                length--;
                            }
                        }

                        if (input[index] >= 5) // enough points
                        {
                            input[index] -= 5;
                            points += 5;
                        }
                        else // not enough points
                        {
                            points += input[index];
                            input[index] = 0;
                        }
                    }
                }
                else if (tokens[0] == "Reverse")
                {
                    input.Reverse();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" - ", input));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}

