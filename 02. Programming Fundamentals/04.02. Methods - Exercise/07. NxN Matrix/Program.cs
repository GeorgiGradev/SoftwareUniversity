using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Matrix(input);

        }

        static void Matrix(int input)
        {
            for (int col = 0; col < input; col++)
            {
                for (int rows = 0; rows < input; rows++)
                {
                    Console.Write($"{input} ");
                }
                Console.WriteLine();
            }
        }
    }
}
