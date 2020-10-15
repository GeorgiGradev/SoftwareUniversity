using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Regex.Split(Console.ReadLine(), @"\s*, \s*").ToArray();
            //string[] input = Console.ReadLine()
            //    .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            string healthPattern = @"[^0-9+\-*\/\.]";
            Regex healthRegex = new Regex(healthPattern);

            string damagePattern = @"-?\d+\.?\d*";
            Regex damageRegex = new Regex(damagePattern);

            string operatorPattern = @"[*\/]";
            Regex operatorRegex = new Regex(operatorPattern);

            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();


            for (int i = 0; i < input.Length; i++)
            {
                string currentDaemon = input[i];
                MatchCollection healthCollection = healthRegex.Matches(currentDaemon);
                double healthValue = 0;
                foreach (Match item in healthCollection)
                {
                    healthValue += char.Parse(item.Value);
                }

                MatchCollection damageCollection = damageRegex.Matches(currentDaemon);
                double damageValue = 0;
                foreach (Match item in damageCollection)
                {
                    damageValue += double.Parse(item.Value);
                }

                MatchCollection operatorCollection = operatorRegex.Matches(currentDaemon);
                foreach (Match item in operatorCollection)
                {
                    string @operator = item.Value;
                    if (@operator == "*")
                    {
                        damageValue *= 2;
                    }
                    else if (@operator == "/")
                    {
                        damageValue /= 2;
                    }
                }

                List<double> list = new List<double>();
                if (!dict.ContainsKey(currentDaemon))
                {
                    dict.Add(currentDaemon, new List<double>());
                }
                list.Insert(0, healthValue);
                list.Insert(1, damageValue);
                dict[currentDaemon] = list;
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }
        }
    }
}
