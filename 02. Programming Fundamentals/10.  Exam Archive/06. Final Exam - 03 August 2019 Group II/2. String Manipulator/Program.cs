using System;
using System.Globalization;

namespace _2._String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Change")
                {
                    string @char = tokens[1];
                    string replacement = tokens[2];
                    text = text.Replace(@char, replacement);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string includes = tokens[1];
                    Console.WriteLine(text.Contains(includes));
                }
                else if (command == "End")
                {
                    string ends = tokens[1];
                    Console.WriteLine(text.EndsWith(ends));
                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    string @char = tokens[1];
                    Console.WriteLine(text.IndexOf(@char));
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);
                    text = text.Substring(startIndex, length);
                    Console.WriteLine(text);
                }
            }
        }
    }
}
