using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\%(?<name>[A-Z][a-z]+)%.*<(?<product>\w+)>.*\|(?<count>[0-9]+)\|[A-Za-z]*(?<price>\d+\.?\d*)\$";
            double sum = 0;
            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double total = count * price;
                    sum += total;
                    Console.WriteLine($"{name}: {product} - {total:f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
