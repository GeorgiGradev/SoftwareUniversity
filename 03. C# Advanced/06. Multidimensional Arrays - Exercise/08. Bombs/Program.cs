using System;
using System.Linq;

namespace _08._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                int[] coordinates = input[i].Split(",").Select(int.Parse).ToArray();
                int rowTarget = coordinates[0];
                int colTarget = coordinates[1];
                if (matrix[rowTarget, colTarget] > 0)
                {
                    matrix = NewMatrix(matrix, rowTarget, colTarget, n);
                }
            }
            int SumAliveCells = 0;
            int aliveCells = 0;
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    aliveCells++;
                    SumAliveCells += item;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {SumAliveCells}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] NewMatrix(int[,] matrix, int rowTarget, int colTarget, int n)
        {
            if (rowTarget - 1 >= 0 && rowTarget - 1 < n && colTarget >= 0 && colTarget < n)
            {
                if (matrix[rowTarget - 1, colTarget] > 0)
                {
                    matrix[rowTarget - 1, colTarget] -= matrix[rowTarget, colTarget];
                }
            }
            if (rowTarget - 1 >= 0 && rowTarget - 1 < n && colTarget + 1 >= 0 && colTarget + 1 < n)
            {
                if (matrix[rowTarget - 1, colTarget + 1] > 0)
                {
                    matrix[rowTarget - 1, colTarget + 1] -= matrix[rowTarget, colTarget];
                }
            }
            if (rowTarget >= 0 && rowTarget < n && colTarget + 1 >= 0 && colTarget + 1 < n)
            {
                if (matrix[rowTarget, colTarget + 1] > 0)
                {
                    matrix[rowTarget, colTarget + 1] -= matrix[rowTarget, colTarget];
                }
            }
            if (rowTarget + 1 >= 0 && rowTarget + 1 < n && colTarget + 1 >= 0 && colTarget + 1 < n)
            {
                if (matrix[rowTarget + 1, colTarget + 1] > 0)
                {
                    matrix[rowTarget + 1, colTarget + 1] -= matrix[rowTarget, colTarget];
                }
            }
            if (rowTarget + 1 >= 0 && rowTarget + 1 < n && colTarget >= 0 && colTarget < n)
            {
                if (matrix[rowTarget + 1, colTarget] > 0)
                {
                    matrix[rowTarget + 1, colTarget] -= matrix[rowTarget, colTarget];
                }
            }
            if (rowTarget + 1 >= 0 && rowTarget + 1 < n && colTarget - 1 >= 0 && colTarget - 1 < n)
            {
                if (matrix[rowTarget + 1, colTarget - 1] > 0)
                {
                    matrix[rowTarget + 1, colTarget - 1] -= matrix[rowTarget, colTarget];
                }
            }
            if (rowTarget >= 0 && rowTarget < n && colTarget - 1 >= 0 && colTarget < n)
            {
                if (matrix[rowTarget, colTarget - 1] > 0)
                {
                    matrix[rowTarget, colTarget - 1] -= matrix[rowTarget, colTarget];
                }
            }
            if (rowTarget - 1 >= 0 && rowTarget - 1 < n && colTarget - 1 >= 0 && colTarget - 1 < n)
            {
                if (matrix[rowTarget - 1, colTarget - 1] > 0)
                {
                    matrix[rowTarget - 1, colTarget - 1] -= matrix[rowTarget, colTarget];
                }
            }
            matrix[rowTarget, colTarget] = 0;
            return matrix;
        }
    }
}
