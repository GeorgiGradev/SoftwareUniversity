using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");

                if (input[0] == "Revision")
                {
                    break;
                }    

                else
                {
                    string shop = input[0];
                    string product = input[1];
                    double price = double.Parse(input[2]);

                    if (!dict.ContainsKey(shop))
                    {
                        dict.Add(shop, new Dictionary<string, double>());
                    }
                    dict[shop].Add(product, price);
                }
            }    

            foreach (var (key, value) in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}->");
                foreach (var item in value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }

        }
    }
}
