using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks.Dataflow;
using System.Reflection.Emit;
using System.Net.NetworkInformation;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public class DictValues
        {
            public int Rarity { get; set; }
            public double Rating { get; set; }
            public DictValues(int rarity, double rating)
            {
                this.Rarity = rarity;
                this.Rating = rating;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, DictValues> dict = new Dictionary<string, DictValues>();
            int ratity = 0;
            double rating = 0;

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("<->");
                string plant = tokens[0];
                int rarity = int.Parse(tokens[1]);
                DictValues dictValues = new DictValues(rarity, rating);

                if (!dict.ContainsKey(plant))
                {
                    dict.Add(plant, dictValues);

                }
                dict[plant].Rarity = rarity;
            }
            string input = string.Empty;
            int count = 0;
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] tokens = input.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string plant = tokens[1];
 

                if (command == "Rate")
                {
                    rating = int.Parse(tokens[2]);
                    
                    if (dict[plant].Rating == 0)
                    {
                        dict[plant].Rating = rating;
                        count = 0;
                    }
                    else if (count < 1)
                    {
                        dict[plant].Rating = (dict[plant].Rating + rating) / 2;
                        count++;
                    }
                    else
                    {
                        dict[plant].Rating += rating / 2;
                        count++;
                    }
                }
                else if (command == "Update")
                {
                    ratity = int.Parse(tokens[2]);
                    dict[plant].Rarity = ratity;
                }
                else if (command.Contains("Reset"))
                {
                    dict[plant].Rating = 0;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var name in dict.OrderByDescending(x => x.Value.Rarity)
                               .ThenByDescending(x => x.Value.Rating))
            {
                Console.WriteLine($"- {name.Key}; Rarity: {name.Value.Rarity}; Rating: {name.Value.Rating:f2}");
            }
        }
    }
}
