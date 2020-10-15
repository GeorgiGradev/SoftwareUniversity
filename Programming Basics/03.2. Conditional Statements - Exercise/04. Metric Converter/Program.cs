using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = (Console.ReadLine());
            string output = (Console.ReadLine());

            if (input == "mm" & output == "m")
            {
                Console.WriteLine($"{number * 0.001:F3}");
            }
            if (input == "mm" & output == "cm")
            {
                Console.WriteLine($"{number * 0.1:F3}");
            }
            if (input == "cm" & output == "m")
            {
                Console.WriteLine($"{number * 0.01:F3}");
            }
            if (input == "cm" & output == "mm")
            {
                Console.WriteLine($"{number * 10:F3}");
            }
            if (input == "m" & output == "cm")
            {
                Console.WriteLine($"{number * 100:F3}");
            }
            if (input == "m" & output == "mm")
            {
                Console.WriteLine($"{number * 1000:F3}");
            }
        }
    }
}
