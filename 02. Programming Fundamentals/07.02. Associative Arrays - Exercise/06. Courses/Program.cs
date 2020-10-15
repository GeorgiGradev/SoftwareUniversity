using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(" : ")
                    .ToList();
                string courseName = input[0];

                if (courseName == "end")
                {
                    break;
                }
                else
                {
                    string studentName = input[1];
                    if (!dict.ContainsKey(courseName))
                    {
                        dict.Add(courseName, new List<string>());
                        dict[courseName].Add(studentName);
                    }
                    else
                    {
                        dict[courseName].Add(studentName);
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");

                foreach (var name in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}