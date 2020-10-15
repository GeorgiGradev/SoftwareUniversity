using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('&')
                .ToList();
            string command = Console.ReadLine(); 

            while (command != "Done")
            {
                string[] tokens = command
                    .Split(" | ")
                    .ToArray();

                if (tokens[0] == "Add Book")
                {
                    string book = tokens[1];
                    if (!input.Contains(book))
                    {
                        input.Insert(0, book);
                    }
                }
                else if (tokens[0] == "Take Book")
                {
                    string book = tokens[1];
                    if (input.Contains(book))
                    {
                        input.Remove(book);
                    }
                }
                else if (tokens[0] == "Swap Books")
                {
                    string book1 = tokens[1];
                    string book2 = tokens[2];
                    int index1 = 0;
                    int index2 = 0;
                    if (input.Contains(book1) && input.Contains(book2))
                    {
                        index1 = input.IndexOf(book1);
                        index2 = input.IndexOf(book2);
                        input[index1] = book2;
                        input[index2] = book1;
                    }
                }
                else if (tokens[0] == "Insert Book")
                {
                    string book = tokens[1];
                    input.Add(book);
                }
                else if (tokens[0] == "Check Book")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        Console.WriteLine(input[index]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
