using System;
using System.Linq;

namespace _02._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] tokens = input.Split(":|:");
                string command = tokens[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(tokens[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substring = tokens[1];
                    if (message.Contains(substring))
                    {
                        int startIndex = message.IndexOf(substring);
                        string takenOut = message.Substring(startIndex, substring.Length);
                        message = message.Remove(startIndex, substring.Length);
                        //char[] takenOutAsCharArray = takenOut.ToCharArray();
                        //Array.Reverse(takenOutAsCharArray);
                        //string output = new string(takenOutAsCharArray);

                        string output = new string(substring.Reverse().ToArray());
                        message = message + output;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string substring = tokens[1];
                    string replacement = tokens[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}


