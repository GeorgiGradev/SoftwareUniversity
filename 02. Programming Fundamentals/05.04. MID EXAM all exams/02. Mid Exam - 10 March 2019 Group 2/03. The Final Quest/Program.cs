using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                if (tokens[0] == "Delete")
                {
                    int index = int.Parse(tokens[1]) + 1;
                    if (index <= input.Count-1)
                    {
                        input.RemoveAt(index + 1);
                    }
                }
                else if (tokens[0] == "Swap")
                {
                    string word1 = tokens[1];
                    string word2 = tokens[2];
                    if (input.Contains(word1) && input.Contains(word2))
                    {
                        int index1 = input.IndexOf(word1);
                        int index2 = input.IndexOf(word2);

                        if (index1 < index2)
                        {
                            input.RemoveAt(index2);
                            input.RemoveAt(index1);
                            input.Insert(index1, word2);
                            input.Insert(index2, word1);
                        }
                        else if (index2 < index1)
                        {
                            input.RemoveAt(index1);
                            input.RemoveAt(index2);
                            input.Insert(index2, word1);
                            input.Insert(index1, word2);
                        }
                    }
                }
                else if (tokens[0] == "Put")
                {
                    string word = tokens[1];
                    int index = int.Parse(tokens[2]) - 1;
                    if (index <= input.Count - 1 && index >= 0)
                    {
                        input.Insert(index, word);
                    }
                    if (index == input.Count)
                    {
                        input.Add(word);
                    }
                }
                else if (tokens[0] == "Sort")
                {
                    List<string> input1 = input.OrderByDescending(x => x).ToList();
                    input = input1;
                }
                else if (tokens[0] == "Replace")
                {
                    string word1 = tokens[1];
                    string word2 = tokens[2];
                    if (input.Contains(word2))
                    {
                        int index = input.IndexOf(word2);
                        input.RemoveAt(index);
                        input.Insert(index, word1);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
