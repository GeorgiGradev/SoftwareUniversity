using System;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Numerics;

namespace _03._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ReadDimensions();
            int rows = dimensions[0];
            int cols = dimensions[1];
            
            int[,] matrix = FillMatrix(rows, cols);
            int bestRow = 0;
            int bestCol = 0;

            int biggestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = 0;
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {biggestSum}");
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        public static int[] ReadDimensions()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return dimensions;
        }
        public static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            return matrix;
        }
    }
}
