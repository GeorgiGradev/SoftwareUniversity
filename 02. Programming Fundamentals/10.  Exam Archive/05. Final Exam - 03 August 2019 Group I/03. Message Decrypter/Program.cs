using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace _03._Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string pattern = @"^(?<separator>[$|%]{1})(?<tag>[A-Z]{1}[a-z]{2,})\k<separator>: (?<groups>[\[0-9\]]+\|[\[0-9\]]+\|[\[0-9\]]+\|)$";

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (regex.IsMatch(input))
                {
                    string[] partitions = match.Groups["groups"].Value.Split("]|[");

                    string outputLetter = string.Empty;
                    for (int k = 0; k < partitions.Length; k++)
                    {
                        string numbers = string.Empty;
                        for (int l = 0; l < partitions[k].Length; l++)
                        {
                            if (char.IsDigit(partitions[k][l]))
                            {
                                numbers += partitions[k][l];
                            }
                        }
                        int number = int.Parse(numbers);
                        outputLetter += (char)number;

                    }
                    Console.WriteLine($"{match.Groups["tag"].Value}: {outputLetter}");



                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }



            }



        }
    }
}
