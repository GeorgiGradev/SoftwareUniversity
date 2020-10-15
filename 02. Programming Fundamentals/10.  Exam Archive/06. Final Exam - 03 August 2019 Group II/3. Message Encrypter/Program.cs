using System;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace _3._Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(?<delimiter>[*|@])(?<tag>[A-Z][a-z]{2,})(\k<delimiter>): \[(?<group1>[A-Za-z]+)]\|\[(?<group2>[A-Za-z]+)]\|\[(?<group3>[A-Za-z]+)]\|$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (regex.IsMatch(input))
                {
                    Console.WriteLine($"{match.Groups["tag"].Value}: " +
                        $"{(int)char.Parse(match.Groups["group1"].Value)} " +
                        $"{(int)char.Parse(match.Groups["group2"].Value)} " +
                        $"{(int)char.Parse(match.Groups["group3"].Value)}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
