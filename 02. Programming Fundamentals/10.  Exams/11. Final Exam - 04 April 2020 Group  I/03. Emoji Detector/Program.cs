using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string emojiPattern = @"([:]{2}|[*]{2})([A-Z][a-z]{2,})(\1)";
            string digitPattern = @"[0-9]+";

            Dictionary<string, int> dict = new Dictionary<string, int>();

            Regex emojiRegex = new Regex(emojiPattern);
            Regex digitRegex = new Regex(digitPattern);

            MatchCollection digitMatches = digitRegex.Matches(text);
            StringBuilder sb = new StringBuilder();

            foreach (Match item in digitMatches)
            {
                sb.Append(item);
            }
            string digitAsString = sb.ToString();
            int coolness = 1;
            for (int i = 0; i < digitAsString.Length; i++)
            {
                coolness *= int.Parse(digitAsString[i].ToString());
            }

            Console.WriteLine($"Cool threshold: {coolness}");

            MatchCollection emojiMatches = emojiRegex.Matches(text);

            foreach (Match item in emojiMatches)
            {
                int asciiSum = 0;
                string emoji = item.ToString();
                for (int i = 0; i < emoji.Length; i++)
                {
                    if (char.IsLetter(emoji[i]))
                    {
                        asciiSum += emoji[i];
                    }
                   
                }
                dict.Add(emoji, asciiSum);
            }

            Console.WriteLine($"{dict.Keys.Count} emojis found in the text. The cool ones are:");
            foreach (var item in dict.Where(x => x.Value > coolness))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
