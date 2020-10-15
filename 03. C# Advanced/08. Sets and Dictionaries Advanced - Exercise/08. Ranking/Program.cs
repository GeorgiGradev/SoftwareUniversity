using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace _08._Ranking
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> introDict = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of contests")
                {
                    break;
                }
                else
                {
                    string courseName = input[0];
                    string passWord = input[1];
                    introDict.Add(courseName, passWord);
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of submissions")
                {
                    break;
                }
                else
                {
                    string courseName = input[0];
                    string passWord = input[1];
                    string userName = input[2];
                    int points = int.Parse(input[3]);

                    if (introDict.ContainsKey(courseName) && passWord == introDict[courseName])
                    {
                        if (!dict.ContainsKey(userName))
                        {
                            dict.Add(userName, new Dictionary<string, int>());
                            dict[userName].Add(courseName, points);
                        }
                        else if (!dict[userName].ContainsKey(courseName))
                        {
                            dict[userName].Add(courseName, points);
                        }
                        else if (dict[userName][courseName] < points)
                        {
                            dict[userName][courseName] = points;
                        }
                    }
                }
            }

            foreach (var item in dict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Values.Sum()} points.");
                break;
            }
            Console.WriteLine("Ranking:");
            foreach (var (key, value) in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine(key);
                foreach (var item in value.OrderByDescending(x => x.Value))
                {
                    string courseName = item.Key;
                    int points = item.Value;
                    Console.WriteLine($"#  {courseName} -> {points}");
                }
            }
        }
    }
}

