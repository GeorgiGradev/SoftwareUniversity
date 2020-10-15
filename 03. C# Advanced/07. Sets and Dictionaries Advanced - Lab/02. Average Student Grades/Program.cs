using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if(!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<decimal>());
                }
                dict[name].Add(grade);
            }

            foreach (var (nameKey, gradeValue) in dict)
            {
                string name = nameKey;
                string grade = string.Join(" ", gradeValue.Select(x => x.ToString("F2")));
                decimal averageGrade = gradeValue.Average();
                Console.WriteLine($"{name} -> {grade} (avg: {averageGrade:f2})");
            }
        }
    }
}
