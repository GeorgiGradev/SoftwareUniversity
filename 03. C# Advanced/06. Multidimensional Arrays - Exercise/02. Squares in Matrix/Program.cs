using System;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ReadDimensions();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
 
            int counter = 0;

            matrix = FillMatrix(rows, cols);


            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char element = matrix[row, col];
                    if (matrix[row, col + 1] == element &&
                        matrix[row + 1, col] == element &&
                        matrix[row + 1, col + 1] == element)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        public static int[] ReadDimensions()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return dimensions;
        }
        public static char[,] FillMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
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
