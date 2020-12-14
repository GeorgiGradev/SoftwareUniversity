using System;
using System.Text.RegularExpressions;

namespace _03._The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string input = Console.ReadLine();
                string pattern = @"^(?<separator>[\#\$\%\*\&]+)(?<name>[A-Za-z]+)\k<separator>=(?<length>[0-9]+)!!(?<code>.+)$";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                string encryptedCode = string.Empty;

                if (regex.IsMatch(input))
                {
                    string name = match.Groups["name"].Value;
                    int lenght = int.Parse(match.Groups["length"].Value);
                    string code = match.Groups["code"].Value;
                    int codeLenght = code.Length;
                    if (lenght == codeLenght)
                    {
                        for (int i = 0; i < code.Length; i++)
                        {
                            encryptedCode += (char)(code[i] + lenght);
                        }
                        Console.WriteLine($"Coordinates found! {name} -> {encryptedCode}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
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
