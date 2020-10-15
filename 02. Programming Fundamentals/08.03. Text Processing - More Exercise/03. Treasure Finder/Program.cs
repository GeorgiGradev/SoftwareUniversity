using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Security;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            while (command != "find")
            {
                StringBuilder sb = new StringBuilder();
                string type = string.Empty;
                string coordinates = string.Empty;
                int l = 0;
                for (int i = 0; i < command.Length; i++)
                {
                    sb.Append((char)(command[i] - input[l]));
                    l++;
                    if (l == input.Length)
                    {
                        l = 0;
                    }
                }
                string[] type1 = sb.ToString()
                    .Split('&')
                    .ToArray();
                string[] coord1 = sb.ToString()
                    .Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                type = type1[1];
                coordinates = coord1[1];
                Console.WriteLine($"Found {type} at {coordinates}");
                command = Console.ReadLine();
            }
        }
    }
}

