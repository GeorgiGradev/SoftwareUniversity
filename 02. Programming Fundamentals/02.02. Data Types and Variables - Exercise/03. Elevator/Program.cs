using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int persons = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(capacity / (double)persons);
            Console.WriteLine(courses);
        }
    }
}
