using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterialDict = new Dictionary<string, int>();
            var junkDict = new SortedDictionary<string, int>();
            string fragments = string.Empty;
            string motes = string.Empty;
            string shards = string.Empty;

            keyMaterialDict["fragments"] = 0;
            keyMaterialDict["motes"] = 0;
            keyMaterialDict["shards"] = 0;

            int count = 0;
            int quantity = 0;
            bool isDone = false;
            List<string> input = new List<string>();

            while (true)
            {
                input = Console.ReadLine()
                        .ToLower()
                        .Split()
                        .ToList();

                for (int i = 0; i < input.Count; i++)
                {
                    count++;
                    if (count % 2 != 0)
                    {
                        quantity = int.Parse(input[i]);
                    }
                    else if (count % 2 == 0 && (input[i] == "fragments" || input[i] == "motes" || input[i] == "shards"))
                    {
                        keyMaterialDict[input[i]] += quantity;
                        if (keyMaterialDict[input[i]] >= 250)
                        {
                            keyMaterialDict[input[i]] -= 250;
                            isDone = true;
                            if (input[i] == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (input[i] == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (input[i] == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (!junkDict.ContainsKey(input[i]))
                        {
                            junkDict[input[i]] = 0;
                        }
                        junkDict[input[i]] += quantity;
                    }
                }
                if (isDone == true)
                {
                    break;
                }
            }

            foreach (var item in keyMaterialDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }   
        }
    }
}
