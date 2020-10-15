using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] input = Console.ReadLine()
                 .Split('|');
            for (int i = 0; i < input.Length; i++)
            {
                string[] tokens = input[i]
                    .Split()
                    .ToArray();
                string monsterCommand = tokens[0];
                int number = int.Parse(tokens[1]);

                if (monsterCommand == "potion")
                {
                    health += number;
                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - (health - number)} hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (monsterCommand == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monsterCommand}.");
                    }
                    else if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monsterCommand}.");
                        Console.WriteLine($"Best room: {i+1}");
                        break;
                    }
                }
            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
