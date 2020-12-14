using System;
using System.Dynamic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Replace")
                {
                    char currentChar = char.Parse(tokens[1]);
                    char newChar = char.Parse(tokens[2]);
                    text = text.Replace(currentChar, newChar);
                    Console.WriteLine(text);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && endIndex >= startIndex && endIndex < text.Length)
                    {
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (command == "Make")
                {
                    string upperLower = tokens[1];
                    if (upperLower == "Upper")
                    {
                        text = text.ToUpper();
                    }
                    else if (upperLower == "Lower")
                    {
                        text = text.ToLower();
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Check")
                {
                    string @string = tokens[1];
                    if (text.Contains(@string))
                    {
                        Console.WriteLine($"Message contains {@string}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {@string}");
                    }
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && endIndex >= startIndex && endIndex < text.Length)
                    {
                        string sub = text.Substring(startIndex, endIndex - startIndex + 1);
                        int sum = 0;
                        for (int i = 0; i < sub.Length; i++)
                        {
                            sum += sub[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
            }
        }
    }
}
