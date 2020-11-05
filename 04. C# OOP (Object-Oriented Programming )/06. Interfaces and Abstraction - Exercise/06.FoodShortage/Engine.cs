using FoodShortage.Models;
using FoodShortage.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace FoodShortage
{ 
    public static class Engine
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            string name = string.Empty;
            int age = 0;
            string ID = string.Empty;
            string birthDate = string.Empty;
            string group = string.Empty;

            Citizen citizen = new Citizen(name, age, ID, birthDate);
            Rebel rebel = new Rebel(name, age, group);
            List<Citizen> citizenList = new List<Citizen>();
            List<Rebel> rebelList = new List<Rebel>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens.Length == 4)
                {
                    name = tokens[0];
                    age = int.Parse(tokens[1]);
                    ID = tokens[2];
                    birthDate = tokens[3];
                    citizen = new Citizen(name, age, ID, birthDate);
                    citizenList.Add(citizen);
                }
                else if (tokens.Length == 3)
                {
                    name = tokens[0];
                    age = int.Parse(tokens[1]);
                    group = tokens[2];
                    rebel = new Rebel(name, age, group);
                    rebelList.Add(rebel);
                }
            }
            string input;
            int foodCount = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                if (citizenList.Any(x=>x.Name == input))
                {
                    foodCount += citizen.BuyFood();
                }
                else if (rebelList.Any(x=>x.Name == input))
                {
                    foodCount += rebel.BuyFood();
                }
            }

            Console.WriteLine(foodCount);
        }
    }
}
