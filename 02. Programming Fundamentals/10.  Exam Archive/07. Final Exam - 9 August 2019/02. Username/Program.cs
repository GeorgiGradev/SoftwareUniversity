using System;
using System.Linq;
using System.Text;

namespace _02._Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Sign up")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Case")
                {
                    string lowerUpper = tokens[1];
                    if (lowerUpper == "lower")
                    {
                        userName = userName.ToLower();
                    }
                    else if (lowerUpper == "upper")
                    {
                        userName = userName.ToUpper();
                    }
                    Console.WriteLine(userName);
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && endIndex > startIndex && endIndex < userName.Length)
                    {
                        string reversed = userName.Substring(startIndex, endIndex - startIndex + 1);
                        char[] reversedAscharArray = reversed.ToCharArray();      
                        Array.Reverse(reversedAscharArray);
                        reversed = new string(reversedAscharArray);
                        Console.WriteLine(reversed);
                    }
                }
                else if (command == "Cut")
                {
                    string substring = tokens[1];
                    if (userName.Contains(substring))
                    {
                        int index = userName.IndexOf(substring);
                        userName = userName.Remove(index, substring.Length);
                        Console.WriteLine(userName);
                    }
                    else
                    {
                        Console.WriteLine($"The word {userName} doesn't contain {substring}.");
                    }
                }
                else if (command == "Replace")
                {
                    string replace = tokens[1];
                    userName = userName.Replace(replace, "*");
                    Console.WriteLine(userName);
                }
                else if (command == "Check")
                {
                    string contains = tokens[1];

                    if (userName.Contains(contains))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {contains}.");
                    }
                }
            }
        }
    }
}
