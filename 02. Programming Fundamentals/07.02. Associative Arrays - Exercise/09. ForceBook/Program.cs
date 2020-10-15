using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var dict = new Dictionary<string, string>();

            string user = string.Empty; // key
            string side = string.Empty; // value


            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                var input = command
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (command.Split().Contains("|"))
                {
                    user = input[1]; // key
                    side = input[0]; // value

                    if (!dict.ContainsKey(user))
                    {
                        dict.Add(user, side);
                    }

                }
                else if (command.Split().Contains("->"))
                {
                    user = input[0]; // key
                    side = input[1]; // value

                    if (dict.ContainsKey(user))
                    {
                        dict[user] = side;
                    }
                    else
                    {
                        dict.Add(user, side);
                    }
                    Console.WriteLine($"{user} joins the {side} side!");
                }

            }
            foreach (var Side in dict
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {Side.Key}, Members: {Side.Count()}");
                foreach (var User in Side.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"! {User.Key}");
                }
            }
        }
    }
}


