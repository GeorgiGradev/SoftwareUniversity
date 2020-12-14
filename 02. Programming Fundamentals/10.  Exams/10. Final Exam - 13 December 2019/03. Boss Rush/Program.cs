using System;
using System.Text.RegularExpressions;

namespace _03._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^\|(?<boss>[A-Z]{4,})\|\:\#(?<title>[A-Za-z]+\s[A-Za-z]+)\#$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Access denied!");
                }
                else
                {
                    string boss = match.Groups["boss"].Value;
                    string title = match.Groups["title"].Value;
                    Console.WriteLine($"{boss}, The {title}");
                    Console.WriteLine($">> Strength: {boss.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
            }
        }
    }
}
