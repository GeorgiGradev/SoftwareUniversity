using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            matrix = FillMatrix(rows, cols);
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int counter = -1;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = tokens[0];
                int col = tokens[1];
                if (row < 0 || row >= rows || col < 0 || col >= cols) // излиза извън матрицата
                {
                    Console.WriteLine($"Invalid coordinates.");
                    continue;
                }
                else // остава в матрицата
                {
                    counter++;
                    dict.Add(counter, new List<int>());
                    dict[counter].Add(row);
                    dict[counter].Add(col);

                    for (int horizontal = 0; horizontal < rows; horizontal++)
                    {
                        if (col != horizontal)
                        {
                            matrix[row, horizontal] += 1;
                        }
                    }
                    for (int vertical = 0; vertical < cols; vertical++)
                    {
                        if (row != vertical)
                        {
                            matrix[vertical, col] += 1;
                        }
                    }
                }

            }

            for (int i = 0; i < dict.Count; i++)
            {
                int row = dict[i][0];
                int col = dict[i][1];
                matrix[row, col] = 1;
            }


            PrintMatrix(matrix);
        }
        public static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = 0;
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = string.Empty;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    line += matrix[row, col] + " ";
                }
                line.TrimEnd();
                sb.AppendLine(line);

            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}