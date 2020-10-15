using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace REDO_05._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int totalLength = rows * cols;
            string snake = Console.ReadLine();
            int letterPosition = -1;
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    letterPosition++;
                    matrix[row, col] = snake[letterPosition];
                    if (snake.Length - 1 == letterPosition)
                    {
                        letterPosition = -1;
                    }
                }
            }
            PrintMatrix(matrix);

        }
        public static void PrintMatrix(char[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = string.Empty;

                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        line += matrix[row, col];
                    }
                    line.TrimEnd();
                    sb.AppendLine(line);
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        line += matrix[row, col];
                    }
                    line.TrimEnd();
                    sb.AppendLine(line);
                }

            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}