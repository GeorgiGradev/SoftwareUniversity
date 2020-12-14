using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(?<delimiter>.+)>(?<numbers>[\d]{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<symbols>[^<>]{3})<(\k<delimiter>)$";

            for (int i = 0; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }
                Match match = regex.Match(input);

                string numbers = match.Groups["numbers"].Value;
                string lower = match.Groups["lower"].Value;
                string upper = match.Groups["upper"].Value;
                string symbols = match.Groups["symbols"].Value;

                string password = numbers + lower + upper + symbols;
                Console.WriteLine($"Password: {password}");
            }
        }
    }
}
