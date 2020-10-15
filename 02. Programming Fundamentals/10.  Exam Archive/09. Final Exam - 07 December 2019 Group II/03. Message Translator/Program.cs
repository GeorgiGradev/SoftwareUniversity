using System;
using System.Data;
using System.Dynamic;
using System.Text;
using System.Text.RegularExpressions;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^\!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    string command = match.Groups["command"].Value;
                    string message = match.Groups["message"].Value;
                    StringBuilder sb = new StringBuilder();

                    for (int k = 0; k < message.Length; k++)
                    {
                        sb.Append((int)message[k] + " ");
                    }
                    message = sb.ToString();
                    Console.WriteLine($"{command}: {message}");
                }
            }
        }
    }
}
