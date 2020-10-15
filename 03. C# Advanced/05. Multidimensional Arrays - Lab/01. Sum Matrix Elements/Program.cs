using System;
using System.Dynamic;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ParseArray();
            int row = dimensions[0];
            int column = dimensions[1];
            int[,] matrix = new int[row, column];

            for (int rows = 0; rows < row; rows++)
            {
                int[] input = ParseArray();
                for (int columns = 0; columns < column; columns++)
                {
                    matrix[rows, columns] = input[columns];
                }
            }
            int sum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    sum += matrix[rows, columns];
                }
            }

            Console.WriteLine(row);
            Console.WriteLine(column);
            Console.WriteLine(sum);

        }
        static int[] ParseArray() =>
            Console.ReadLine()
                .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
}
