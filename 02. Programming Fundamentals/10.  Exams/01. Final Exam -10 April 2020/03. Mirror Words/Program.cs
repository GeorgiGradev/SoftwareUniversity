using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace _03._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"(?<del>[@|#]{1})[A-Za-z]{3,}(\k<del>)(\k<del>)[A-Za-z]{3,}(\k<del>)");
            MatchCollection matches = regex.Matches(text);
            List<string> pairs = new List<string>();
            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();

            foreach (Match match in matches)
            {
                pairs.Add(match.Value);
            }

            for (int i = 0; i < pairs.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int k = 0; k < pairs[i].Length; k++)
                {
                    if (char.IsLetter(pairs[i][k]))
                    {
                        sb.Append(pairs[i][k]);
                    }
                } // abcdef
                string pair = sb.ToString();
                string pair1 = pair.Substring(0, pair.Length / 2);
                string pair2 = pair.Substring((pair.Length / 2), pair.Length / 2);
                char[] pair2asCharArray = pair2.ToCharArray();
                Array.Reverse(pair2asCharArray);
                string test2 = new string(pair2asCharArray);

                if (pair1 == test2 && pair1.Length == pair2.Length)
                {
                    mirrorWords.Add(pair1, pair2);
                }
            }
            if (pairs.Count > 0)
            {
                Console.WriteLine($"{pairs.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
           

            if (mirrorWords.Keys.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                string result = string.Empty;
                foreach (var item in mirrorWords)
                {
                    result += $"{item.Key} <=> {item.Value}, ";
                }
                result = result.TrimEnd();
                result = result.Remove(result.Length - 1, 1);
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
