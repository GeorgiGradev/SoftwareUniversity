using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, int> dictA = new Dictionary<string, int>();
            Dictionary<string, int> dictD = new Dictionary<string, int>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                int counter = 0;
                for (int k = 0; k < input.Length; k++)
                {
                    if (input[k].ToString().ToLower() == "s"
                       || input[k].ToString().ToLower() == "t"
                        || input[k].ToString().ToLower() == "a"
                       || input[k].ToString().ToLower() == "r")
                    {
                        counter++;
                    }
                }
                StringBuilder sb = new StringBuilder();
                for (int l = 0; l < input.Length; l++)
                {
                    char ch = (char)(input[l] - counter);
                    sb.Append(ch);
                }

                string message = sb.ToString();
                string pattern = @"@(?<planet>[A-Za-z]+)[^@,\-!:>]*:(?<population>[0-9]+)[^@,\-!:>]*!(?<attack>[AD])![^@,\-!:>]*->(?<soldier>[0-9]+)";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(message);

                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    if (match.Groups["attack"].Value == "A")
                    {
                        if (!dictA.ContainsKey(planetName))
                        {
                            dictA.Add(planetName, 0);
                        }
                        dictA[planetName] += 1;
                    }
                    else if (match.Groups["attack"].Value == "D")
                    {
                        if (!dictD.ContainsKey(planetName))
                        {
                            dictD.Add(planetName, 0);
                        }
                        dictD[planetName] += 1;
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {dictA.Values.Count}");
            foreach (var item in dictA.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-> {item.Key}");
            }

            Console.WriteLine($"Destroyed planets: {dictD.Values.Count}");
            foreach (var item in dictD.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-> {item.Key}");
            }
        }
    }
}
