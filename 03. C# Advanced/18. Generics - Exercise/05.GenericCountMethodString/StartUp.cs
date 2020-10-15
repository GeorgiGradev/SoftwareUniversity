using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            List<string> input = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                input.Add(element);
            }
            string elementToCompare = Console.ReadLine();
            int counter = box.CountGreaterElements(input, elementToCompare);
            Console.WriteLine(counter);
        }
    }
}
