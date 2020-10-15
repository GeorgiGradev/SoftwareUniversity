using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();
            string command = Console.ReadLine();

            while (command != "No Money")
            {
                string[] gifts = command
                    .Split()
                    .ToArray();

                if (gifts[0] == "OutOfStock")
                {
                    string gift = gifts[1];
                    if (input.Contains(gift))
                    {
                        while (input.Contains(gift))
                        {
                            int index = input.IndexOf(gift);
                            input.RemoveAt(index);
                            input.Insert(index, "None");
                        }
                    }
                }
                else if (gifts[0] == "Required")
                {
                    string gift = gifts[1];
                    int index = int.Parse(gifts[2]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input.RemoveAt(index);
                        input.Insert(index, gift);
                    }
                }
                else if (gifts[0] == "JustInCase")
                {
                    string gift = gifts[1];
                    input.RemoveAt(input.Count - 1);
                    input.Add(gift);
                }
                command = Console.ReadLine();
            }
            if (input.Contains("None"))
            {
                while (input.Contains("None"))
                {
                    input.Remove("None");
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
