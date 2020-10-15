using System;

namespace _02._String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Translate")
                {
                    string charr = tokens[1];
                    string replacement = tokens[2];
                    text = text.Replace(charr, replacement);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string stringg = tokens[1];
                    if (text.Contains(stringg))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Start")
                {
                    string starts = tokens[1];
                    if (text.StartsWith(starts))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                   
                    string index = tokens[1];
                    Console.WriteLine(text.LastIndexOf(index));
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int lenght = int.Parse(tokens[2]);

                    int count = int.Parse(tokens[2]);
                    text = text.Remove(startIndex, lenght);
                    Console.WriteLine(text);
                }
            }
        }
    }
}
