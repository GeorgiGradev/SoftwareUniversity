using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            List<double> input = new List<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                input.Add(element);
            }
            double elementToCompare = double.Parse(Console.ReadLine());
            int counter = box.CountGreaterElements(input, elementToCompare);
            Console.WriteLine(counter);
        }
    }
}
