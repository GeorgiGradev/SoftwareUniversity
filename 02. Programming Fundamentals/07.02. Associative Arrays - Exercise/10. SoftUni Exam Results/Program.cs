using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var dictStudentsPoints = new Dictionary<string, int>();
            var dictLanguageCount = new Dictionary<string, int>();
            string studentName = null;
            string language = null;
            int points = 0;

            while (command != "exam finished")
            {

                var input = command
                    .Split("-")
                    .ToList();
                studentName = input[0];
                language = input[1];

                if (language != "banned")
                {
                    points = int.Parse(input[2]);
                    if (!dictStudentsPoints.ContainsKey(studentName))
                    {
                        dictStudentsPoints[studentName] = 0;
                    }
                    if (points > dictStudentsPoints[studentName])
                    {
                        dictStudentsPoints[studentName] = points;
                    }

                    if (!dictLanguageCount.ContainsKey(language))
                    {
                        dictLanguageCount[language] = 1;
                    }
                    else if (dictLanguageCount.ContainsKey(language))
                    {
                        dictLanguageCount[language]++;
                    }
                }
                else if (language == "banned")
                {
                    dictStudentsPoints.Remove(studentName);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var item in dictStudentsPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in dictLanguageCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
