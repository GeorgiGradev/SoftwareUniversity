using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            bool isVip = false;
            while (true)
            {
                string invitedGuest = Console.ReadLine();
                if (invitedGuest == "PARTY")
                {
                    break;
                }
                else if (invitedGuest.Length == 8)
                {
                    set.Add(invitedGuest);
                }
            }


            while (true)
            {
                string arrivedGuest = Console.ReadLine();
                if (arrivedGuest == "END")
                {
                    break;
                }
                else if (set.Contains(arrivedGuest))
                {
                    set.Remove(arrivedGuest);
                }
            }



            Console.WriteLine(set.Count());
            if (set.Count() > 0)
            {
                foreach (var item in set)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        char firstLetter = item[0];
                        if (Char.IsDigit(firstLetter))
                        {
                            isVip = true;
                        }
                    }
                }

                if (isVip)
                {
                    set.OrderBy(x => x);
                    foreach (var item in set)
                    {
                        Console.WriteLine(item);
                    }

                }
                else
                {
                    foreach (var item in set)
                    {
                        Console.WriteLine(item);
                    }
                }
            }



        }
    }
}

