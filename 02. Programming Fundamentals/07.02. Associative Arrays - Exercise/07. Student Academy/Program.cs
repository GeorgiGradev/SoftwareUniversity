using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();
            string name = string.Empty;
            double grade = 0;

            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                    dict[name].Add(grade);
                }
                else
                {
                    dict[name].Add(grade);
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value.Average()).Where(x => x.Value.Average() >= 4.5))
            {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
 