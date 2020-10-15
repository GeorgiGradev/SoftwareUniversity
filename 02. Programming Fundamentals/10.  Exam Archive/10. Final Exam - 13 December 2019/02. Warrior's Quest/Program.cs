using System;
using System.IO;
using System.Text;

namespace _02._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "GladiatorStance")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "DefensiveStance")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "Dispel")
                {
                    int index = int.Parse(tokens[1]);
                    char letter = char.Parse(tokens[2]);
                    if (index >= 0 && index < text.Length)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (i == index)
                            {
                                sb.Append(letter);
                            } 
                            else
                            {
                                sb.Append(text[i]);
                            }
                        }
                        text = sb.ToString();
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (command == "Target")
                {
                    string changeRemove = tokens[1];
                    string subString = tokens[2];
                    if (changeRemove == "Change")
                    {
                        string secondSubstring = tokens[3];
                        text = text.Replace(subString, secondSubstring);
                        Console.WriteLine(text);
                    }
                    else if (changeRemove == "Remove")
                    {
                        int index = text.IndexOf(subString);
                        text = text.Remove(index, subString.Length);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }
        }
    }
}
