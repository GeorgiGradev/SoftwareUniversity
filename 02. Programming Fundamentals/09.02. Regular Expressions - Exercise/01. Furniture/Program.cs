using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>([A-Za-z]+|[A-Z]+)<<(\d+|\d+\.\d+)!(\d+)";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Bought furniture:");
            double sum = 0;

            while (input != "Purchase")
            {

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);
                    double totalPrice = price * quantity;
                    sum += totalPrice;
                    Console.WriteLine(name);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
