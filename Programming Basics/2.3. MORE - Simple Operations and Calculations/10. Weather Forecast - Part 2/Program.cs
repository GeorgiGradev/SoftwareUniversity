using System;

namespace _10._Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

           if (grade < 5)
            {
                Console.WriteLine("unknown");
            }
            else if (grade < 12)
            {
                Console.WriteLine("Cold");
            }
            else if (grade < 15)
            {
                Console.WriteLine("Cool");
            }
            else if (grade < 20.1)
            {
                Console.WriteLine("Mild");
            }
            else if (grade < 26)
            {
                Console.WriteLine("Warm");
            }
            else if (grade < 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
