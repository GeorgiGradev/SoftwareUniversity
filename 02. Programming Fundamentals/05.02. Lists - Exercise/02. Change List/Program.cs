using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> transformCommand = command.Split().ToList();

                if (transformCommand[0] == "Delete")
                {
                    input.RemoveAll(x => x == transformCommand[1]);
                }
                else if (transformCommand[0] == "Insert")
                {
                    string element = transformCommand[1];
                    int pos = int.Parse(transformCommand[2]);
                    input.Insert(pos, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
