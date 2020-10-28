using System;
using System.Collections.Generic;

namespace _7.SoftUniParty
{
    public class StartUp
    {
        public static void Main()
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(line[0]))
                {
                    vipGuests.Add(line);
                }
                else
                {
                    regularGuests.Add(line);
                }
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                if (vipGuests.Contains(line))
                {
                    vipGuests.Remove(line);
                }
                else if (regularGuests.Contains(line))
                {
                    regularGuests.Remove(line);
                }
            }

            int total = regularGuests.Count + vipGuests.Count;
            Console.WriteLine(total);

            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }

            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}