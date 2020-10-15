using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string []{ "\\", "." }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine($"File name: {input[^2]}");
            Console.WriteLine($"File extension: {input[^1]}");
        }
    }
}
