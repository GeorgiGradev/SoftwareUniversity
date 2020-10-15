using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passangersInWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string commandPassangersAddWagons = Console.ReadLine();

            while(commandPassangersAddWagons != "end")
            {
                List<string> passangersAddWagons = commandPassangersAddWagons.Split().ToList();

                if (passangersAddWagons[0] == "Add")
                {
                    int newWagons = int.Parse(passangersAddWagons[1]);
                    passangersInWagons.Add(newWagons);
                }
                else
                {
                    int newPassangers = int.Parse(passangersAddWagons[0]);
                    for (int i = 0; i < passangersInWagons.Count; i++)
                    {
                        if((wagonCapacity - passangersInWagons[i]) >= newPassangers)
                        {
                            passangersInWagons[i] += newPassangers;

                            //int backUp = passangersInWagons[i];
                            //passangersInWagons.RemoveAt(i);
                            //passangersInWagons.Insert(i, backUp + newPassangers);
                            break;
                        }
                    }
                }
                commandPassangersAddWagons = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", passangersInWagons));
        }
    }
}
