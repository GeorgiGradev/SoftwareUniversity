using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
