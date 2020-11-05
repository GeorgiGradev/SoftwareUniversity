using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public static class Enigne
    {
        public static void Run()
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ").ToArray();
            string[] webSites = Console.ReadLine().Split(" ").ToArray();
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryphone = new StationaryPhone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (phoneNumbers[i].Length == 10)
                {
                    string currentNumber = phoneNumbers[i];
                    if (currentNumber.All(ch => char.IsDigit(ch)))
                    {
                        Console.WriteLine(smartphone.Call(currentNumber));
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }

                }
                else if (phoneNumbers[i].Length == 7)
                {
                    string currentNumber = phoneNumbers[i];
                    if (currentNumber.All(ch => char.IsDigit(ch)))
                    {
                        Console.WriteLine(stationaryphone.Call(currentNumber));
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }                    
            }

            for (int i = 0; i < webSites.Length; i++)
            {
                string currentWebsite = webSites[i];
                if (currentWebsite.Any(ch => char.IsDigit(ch)))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine(smartphone.Browse(currentWebsite));
                }
            }
        }
    }
}
