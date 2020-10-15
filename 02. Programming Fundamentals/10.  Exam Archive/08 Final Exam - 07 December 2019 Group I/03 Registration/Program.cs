using System;
using System.Text.RegularExpressions;

namespace _03_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            string pattern = @"^(?<d1>[U$]{2})(?<username>[A-Z][a-z]{2,})(\k<d1>)(?<d2>[P@$]{3})(?<password>[A-z]{5,}[\d]+)(\k<d2>)$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string userName = match.Groups["username"].Value;
                    string passWord = match.Groups["password"].Value;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {userName}, Password: {passWord}");
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
