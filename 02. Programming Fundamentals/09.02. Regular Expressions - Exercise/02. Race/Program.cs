using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Regex.Split(Console.ReadLine(), ",\\s+").ToList();
            string input = Console.ReadLine();
            Dictionary<string, int> participantsDict = new Dictionary<string, int>();

            string namePattern = @"[A-Za-z]";
            Regex nameRegex = new Regex(namePattern);

            string digitPattern = @"\d";
            Regex digitRegex = new Regex(digitPattern); 

            while (input != "end of race")
            {
                MatchCollection charsCollection = nameRegex.Matches(input);
                string name = string.Join("", charsCollection);

                if (participants.Contains(name))
                {
                    MatchCollection digitCollection = digitRegex.Matches(input);
                    int distance = 0;
                    foreach (Match match in digitCollection)
                    {
                        int digit = int.Parse(match.Value);
                        distance += digit;
                    }

                    if (!participantsDict.ContainsKey(name))
                    {
                        participantsDict.Add(name, 0);
                    }

                    participantsDict[name] += distance;
                }

                input = Console.ReadLine();
            }
            participantsDict = participantsDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            int counter = 1;
            foreach (var item in participantsDict)
            {
                string text = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
                Console.WriteLine($"{counter++}{text} place: {item.Key}");
                if (counter == 4)
                {
                    break;
                }
            }
        }
    }
}
