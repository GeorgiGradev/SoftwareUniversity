using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Strings_and_Text_Processing // World Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                
                if (command == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string @string = tokens[2];
                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, @string);
                        
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex < text.Length 
                        && endIndex >= 0 && endIndex < text.Length)
                    {
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                        
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Switch")
                {
                    string oldString = tokens[1];
                    string newString = tokens[2];
                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);
                        
                    }
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
