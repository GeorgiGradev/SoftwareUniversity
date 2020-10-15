using System;
using System.Collections.Generic;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = Path.Combine("text.txt");
            string path2 = Path.Combine(@"../../../output.txt");

            var lines = File.ReadAllLines(path1);
            List<string> list = new List<string>();
            int letterCounter = 0;
            int puntCounter = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                letterCounter = 0;
                puntCounter = 0;
                for (int k = 0; k < lines[i].Length; k++)
                {
                    if (char.IsLetter(lines[i][k]))
                    {
                        letterCounter++;
                    }
                    else if (!char.IsWhiteSpace(lines[i][k]))
                    {
                        puntCounter++;
                    }
                }
                list.Add($"Line{i + 1}: {lines[i]} ({letterCounter})({puntCounter})");
            }

            File.WriteAllLines(path2, list);

        }
    }
}
