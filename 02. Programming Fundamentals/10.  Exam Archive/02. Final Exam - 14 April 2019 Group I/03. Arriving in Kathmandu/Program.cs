using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace _03._Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Last note")
            {
                string pattern = @"^(?<name>[A-Za-z0-9!@#$?]*)=(?<length>\d+)<<(?<code>.*)$";
          // string pattern =    @"^(?<name>[A-Za-z0-9!@#$?]+)=(?<length>\d+)<<(?<code>(.*?)+)$";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                if (regex.IsMatch(input))
                {
                    foreach (Match match in matches)
                    {
                        string name = match.Groups["name"].Value;
                        int length = int.Parse(match.Groups["length"].Value);
                        string code = match.Groups["code"].Value;
                        string nameResult = string.Empty;

                        for (int i = 0; i < name.Length; i++)
                        {
                            if (char.IsLetterOrDigit(name[i]))
                            {
                                nameResult += name[i];
                            }
                        }

                        if (length == code.Length)
                        {
                            Console.WriteLine($"Coordinates found! {nameResult} -> {code}");
                        }
                        else
                        {
                            Console.WriteLine("Nothing found!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
