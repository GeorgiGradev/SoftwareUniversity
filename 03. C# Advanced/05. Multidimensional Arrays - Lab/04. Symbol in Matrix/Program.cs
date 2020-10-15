using System;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            int rows = dimensions;
            int cols = dimensions;
            bool isTrue = false;
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isTrue = true;
                        break;
                    }
                }
                if (isTrue)
                {
                    break;
                }
            }
            if(!isTrue)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
