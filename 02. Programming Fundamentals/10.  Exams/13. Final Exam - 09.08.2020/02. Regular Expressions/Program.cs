using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Regular_Expressions // Destination Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"([=]{1}|[\/]{1})(?<place>[A-Z][A-Za-z]{2,})\1");
            MatchCollection matches = regex.Matches(text);
            List<string> list = new List<string>();

            int lenght = 0;
            if (regex.IsMatch(text))
            {
                foreach (Match item in matches)
                {
                    string word = item.Groups["place"].Value;
                    lenght += word.Length;
                    list.Add(word);
                }
                Console.WriteLine($"Destinations: {string.Join(", ", list)}");
                Console.WriteLine($"Travel Points: {lenght}");
            }
            else
            {
                Console.WriteLine("Destinations:");
                Console.WriteLine("Travel Points: 0");
            }
        }
    }
}
