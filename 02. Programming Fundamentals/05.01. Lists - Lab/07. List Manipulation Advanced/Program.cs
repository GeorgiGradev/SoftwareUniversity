using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputOriginal = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> input = new List<int>();

            for (int i = 0; i < inputOriginal.Count; i++)
            {
                input.Add(inputOriginal[i]);
            }

            string commandNumbers = Console.ReadLine();

            while (commandNumbers != "end")
            {
                List<string> command = commandNumbers.Split().ToList();


                if (command[0] == "Add")
                {
                    Add(input, command);
                }
                else if (command[0] == "Remove")
                {
                    Remove(input, command);
                }
                else if (command[0] == "RemoveAt")
                {
                    RemoveAt(input, command);
                }
                else if (command[0] == "Insert")
                {
                    Insert(input, command);
                }
                else if (command[0] == "Contains")
                {
                    if (input.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            Console.Write($"{input[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "PrintOdd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 != 0)
                        {
                            Console.Write($"{input[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(input.Sum());
                }
                else if (command[0] == "Filter")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (command[1] == "<")
                        {
                            if (input[i] < int.Parse(command[2]))
                            {
                                Console.Write($"{input[i]} ");
                            }
                        }
                        else if (command[1] == ">")
                        {
                            if (input[i] > int.Parse(command[2]))
                            {
                                Console.Write($"{input[i]} ");
                            }
                        }
                        else if (command[1] == ">=")
                        {
                            if (input[i] >= int.Parse(command[2]))
                            {
                                Console.Write($"{input[i]} ");
                            }
                        }
                        else if (command[1] == "<=")
                        {
                            if (input[i] <= int.Parse(command[2]))
                            {
                                Console.Write($"{input[i]} ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
                commandNumbers = Console.ReadLine();
            }
            string array1 = string.Join(" ", input);
            string array2 = string.Join(" ", inputOriginal);

            if (array1 != array2)
            {
                Console.WriteLine(string.Join(" ",input));
            }
        }
        static List<int> Add(List<int> input, List<string> command)
        {
            int result = int.Parse(command[1]);
            input.Add(result);
            return input;
        }
        static List<int> Remove(List<int> input, List<string> command)
        {
            int result = int.Parse(command[1]);
            input.Remove(result);
            return input;
        }
        static List<int> RemoveAt(List<int> input, List<string> command)
        {
            int result = int.Parse(command[1]);
            input.RemoveAt(result);
            return input;
        }
        static List<int> Insert(List<int> input, List<string> command)
        {
            int result1 = int.Parse(command[1]);
            int result2 = int.Parse(command[2]);
            input.Insert(result2, result1);
            return input;

        }
    }
}
