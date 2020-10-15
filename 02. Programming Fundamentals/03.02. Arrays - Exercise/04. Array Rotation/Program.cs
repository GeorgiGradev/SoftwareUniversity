using System;
using System.Linq;
namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            string firstPosition = string.Empty;

            for (int i = 0; i < rotations; i++)
            {
                firstPosition = input[0];
                for (int k = 0; k < input.Length - 1; k++)
                {
                    input[k] = input[k + 1];
                }
                input[input.Length - 1] = firstPosition;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
