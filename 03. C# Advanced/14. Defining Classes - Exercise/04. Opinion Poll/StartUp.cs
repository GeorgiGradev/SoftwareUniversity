using System;
using System.Runtime.CompilerServices;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                family.AddMember(new Person(name, age));   
            }

            foreach (var member in family.Sort())
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
