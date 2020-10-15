using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine()
            //    .Split();
            //Action<string> action = Print;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    action(input[i]);
            //}

            //}
            //static void Print(string name)
            //{
            //    Console.WriteLine($"Sir {name}");




            Action<string> action = (name) =>
            {
                Console.WriteLine("Sir" + " " + name);
            };

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(action);





            //Console.ReadLine()
            //    .Split()
            //    .ToList()
            //    .ForEach(new Action<string>(name =>
            //    {
            //        Console.WriteLine("Sir" + " " + name);
            //    }));

        }
    }
}
