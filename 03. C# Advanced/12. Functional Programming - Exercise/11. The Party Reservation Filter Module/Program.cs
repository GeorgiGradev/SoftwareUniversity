using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string input = string.Empty;
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            List<string> removed = new List<string>();


            while ((input = Console.ReadLine()) != "Print")
            {
                string[] tokens = input.Split(";").ToArray();
                string addRemoveFilter = tokens[0];
                string filter = tokens[1];
                string letter = tokens[2];

                if (addRemoveFilter == "Add filter")
                {
                    if (!dict.ContainsKey(filter))
                    {
                        dict.Add(filter, new List<string>());
                    }
                    dict[filter].Add(letter);
                }
                else if (addRemoveFilter == "Remove filter")
                {
                    dict[filter].Remove(letter);
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                foreach (var item in dict)
                {
                    if(item.Key == "Starts with")
                    {
                        foreach (var letter in item.Value)
                        {
                            if (names[i].StartsWith(letter))
                            {
                                removed.Add(names[i]);
                            }
                        }
                    }
                    else if (item.Key == "Ends with")
                    {
                        foreach (var letter in item.Value)
                        {
                            if (names[i].EndsWith(letter))
                            {
                                removed.Add(names[i]);
                            }
                        }
                    }
                    else if (item.Key == "Contains")
                    {
                        foreach (var letter in item.Value)
                        {
                            if (names[i].Contains(letter))
                            {
                                removed.Add(names[i]);
                            }
                        }
                    }
                    else if (item.Key == "Length")
                    {
                        foreach (var letter in item.Value)
                        {
                            if (names[i].Length == int.Parse(letter.ToString()))
                            {
                                removed.Add(names[i]);
                            }
                        }
                    }
                }
            }
            foreach (var item in removed)
            {
                if (names.Contains(item))
                {
                    names.Remove(item);
                }
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}

