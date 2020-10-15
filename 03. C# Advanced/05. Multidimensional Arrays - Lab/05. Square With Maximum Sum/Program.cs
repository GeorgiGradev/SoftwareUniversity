using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol +1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
            

        }
    }
}
