using System;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Transactions;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
                jagged[row] = currentRow;
            }
            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens[0] == "End")
                {
                    break;
                }
                else
                {
                    string command = tokens[0];
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    int value = int.Parse(tokens[3]);
                    if (row >= 0 && row < jagged.Length 
                        && col >= 0 && col < jagged[row].Length)
                    {
                        if (command == "Add")
                        {
                            jagged[row][col] += value;
                        }
                        else if (command == "Subtract")
                        {
                            jagged[row][col] -= value;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            foreach (var currentRow in jagged)
            {
                Console.WriteLine(string.Join(" ", currentRow));
            }
        }
    }
}

