using Explicit_Interfaces.Models;
using Explicit_Interfaces.Models.Contracts;
using System;

namespace Explicit_Interfaces.Common
{
    public class Engine
    {
        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                string country = tokens[1];
                int age = int.Parse(tokens[2]);
                Citizen citizen = new Citizen(name, country, age);

                IPerson person = citizen;
                Console.WriteLine(person.GetName());
                IResident resident = citizen;
                Console.WriteLine(resident.GetName());
            }
        }

    }
}
