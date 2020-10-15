using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Upper(input);
            Lower(input);
        }
        static void Upper(int input)
        {
            for (int cols = 1; cols <= input; cols++)
            {
                for (int rows = 1; rows <= cols; rows++)
                {
                    Console.Write($"{rows} ");
                }
                Console.WriteLine();
            }
        }
        static void Lower(int input)
        {
            for (int cols = input - 1; cols > 0; cols--)
            {
                for (int rows = 1; rows <= cols; rows++)
                {
                    Console.Write($"{rows} ");
                }
                Console.WriteLine();
            }
        }
    }
}
