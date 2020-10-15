using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

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
                commandNumbers = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
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
