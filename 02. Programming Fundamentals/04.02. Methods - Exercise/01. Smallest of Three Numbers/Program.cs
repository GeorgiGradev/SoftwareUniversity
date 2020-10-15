using System;
using System.Linq;
namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestNumber());
        }

        static int SmallestNumber()
        {
            int[] numbers = new int[3];
            int[] copy = numbers.ToArray();
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            return numbers[0];
        }
    }
}
