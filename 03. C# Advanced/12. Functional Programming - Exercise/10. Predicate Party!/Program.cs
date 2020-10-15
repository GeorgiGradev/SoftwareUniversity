using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> guests = Console.ReadLine().Split().ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] tokens = command.Split();
                string type = tokens[0];
                string[] predicates = tokens.Skip(1).ToArray();

                Predicate<string> predicate = GetPredicate(predicates);

                if (type == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else if (type == "Double")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        string currGuest = guests[i];
                        if (predicate(currGuest))
                        {
                            guests.Insert(i + 1, currGuest);
                            i++;
                        }
                    }
                }
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }

        }

        static Predicate<string> GetPredicate(string[] predicates)
        {
            string prType = predicates[0];
            string prArg = predicates[1];

            Predicate<string> predicate = null;

            if (prType == "StartsWith")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.StartsWith(prArg);
                }
                );
            }
            else if (prType == "EndsWith")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.EndsWith(prArg);
                }
                );
            }
            else if (prType == "Length")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.Length == int.Parse(prArg);
                }
                );
            }
            return predicate;
        }
    }
}
