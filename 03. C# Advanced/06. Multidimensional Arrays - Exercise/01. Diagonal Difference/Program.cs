using System;
using System.Collections.Concurrent;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            int rows = dimensions;
            int cols = dimensions;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int sum1 = 0;
            int sum2 = 0;
            int counter = -1;
            while (counter != rows - 1)
            {
                counter++;
                sum1 += matrix[0 + counter, 0 + counter];
                sum2 += matrix[0 + counter, cols - counter - 1];
            }
            int total = Math.Abs(sum1 - sum2);
            Console.WriteLine(total);
        }
    }
}
