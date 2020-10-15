using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //    Func<int[], int> func = MinNumber;
            //    Console.WriteLine(func(input));

            //}

            //static int MinNumber(int[] input)
            //{
            //    int result = input.Min();
            //    return result;



            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> func = (array) =>
            {
                int minValue = input.Min();

                return minValue;
            };

            Console.WriteLine(func(input));
        }
    }
}
