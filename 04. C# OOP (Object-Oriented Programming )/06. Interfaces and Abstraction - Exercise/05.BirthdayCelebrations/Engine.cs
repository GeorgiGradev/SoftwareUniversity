using BirthdayCelebrations.Models;
using BirthdayCelebrations.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;


namespace BirthdayCelebrations
{ 
    public static class Engine
    {
        public static void Run()
        {
            string input;

            List<IDatable> list = new List<IDatable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens[0] == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string ID = tokens[3];
                    string birthDate = tokens[4];
                    Human human = new Human(name, age, ID, birthDate);
                    list.Add(human);
                }
                else if (tokens[0] == "Pet")
                {
                    string name = tokens[1];
                    string birthDate = tokens[2];
                    Pet pet = new Pet(name, birthDate);
                    list.Add(pet);
                }
            }

            int year = int.Parse(Console.ReadLine());

            foreach (var item in list)
            {
                int endYear = int.Parse(item.BirthDate.Substring(item.BirthDate.Length - year.ToString().Length));

               if (endYear == year)
                {
                    Console.WriteLine(item.BirthDate);
                }
            }
        }
    }
}
