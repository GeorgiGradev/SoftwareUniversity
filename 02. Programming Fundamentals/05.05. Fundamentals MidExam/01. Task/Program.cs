using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp1 = int.Parse(Console.ReadLine());
            int emp2 = int.Parse(Console.ReadLine());
            int emp3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int hours = 0;
            int totalEml = emp1 + emp2 + emp3;

            while (students > 0)
            {
                hours++;
                if (hours % 4 != 0)
                {
                    students -= totalEml;
                }

            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
