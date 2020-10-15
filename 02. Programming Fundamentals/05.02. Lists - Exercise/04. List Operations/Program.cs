using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> tempList = command.Split().ToList();
                Execute(tempList, input);
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }

        static void Execute(List<string> tempList, List<string> input)
        {
            if (tempList[0] == "Add")
            {
                input.Add(tempList[1]);
            }
            else if (tempList[0] == "Insert")
            {
                int index = int.Parse(tempList[2]);
                if (index > input.Count - 1 || index < 0)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    input.Insert(index, tempList[1]);
                }
            }
            else if (tempList[0] == "Remove")
            {
                int index = int.Parse(tempList[1]);
                if (index > input.Count - 1 || index < 0)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    input.RemoveAt(index);
                }
            }
            else if (tempList[0] == "Shift")
            {
                if (tempList[1] == "left")
                {
                    for (int i = 0; i < int.Parse(tempList[2]); i++)
                    {
                        input.Add(input[0]);
                        input.RemoveAt(0);
                    }
                }
                else if (tempList[1] == "right")
                {
                    for (int i = 0; i < int.Parse(tempList[2]); i++)
                    {
                        input.Insert(0, input[input.Count - 1]);
                        input.RemoveAt(input.Count - 1);
                    }
                }
            }
        }
    }
}
