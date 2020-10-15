using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = Path.Combine("words.txt");
            string path2 = Path.Combine("text.txt");
            string path3 = Path.Combine(@"../../../actualResult.txt");
            string path4 = Path.Combine(@"../../../expectedResult.txt");

            string[] words = File.ReadAllLines(path1);
            string text = File.ReadAllText(path2).ToLower();

            Regex regex = new Regex(@"[a-zA-Z']+");
            MatchCollection matches = regex.Matches(text);

            string word = string.Empty;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int i = 0;
            for (i = 0; i < words.Length; i++)
            {
                foreach (Match item in matches)
                {
                    word = item.ToString();
                    if (words[i] == word)
                    {
                        if (!dict.ContainsKey(word))
                        {
                            dict.Add(word, 0);
                        }
                        dict[word]++;
                    }
                }
            }
            List<string> actual = new List<string>();
            List<string> expected = new List<string>();

            foreach (var item in dict)
            {
                actual.Add($"{item.Key} - {item.Value}");
            }

            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                expected.Add($"{item.Key} - {item.Value}");
            }

            File.WriteAllLines(path3, actual);
            File.WriteAllLines(path4, expected);



        }
    }
}
