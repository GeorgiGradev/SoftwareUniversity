using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace _02.Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            int nikoladzeRow = 0;
            int nikoladzeCol = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'S')
                    {
                        row = rows;
                        col = cols;
                    }
                    if (matrix[rows, cols] == 'N')
                    {
                        nikoladzeRow = rows;
                        nikoladzeCol = cols;
                    }
                }
            }

            string commands = Console.ReadLine();
            for (int i = 0; i < commands.Length; i++)
            {
                char command = commands[i];
                matrix[row, col] = '.';
                EnemyMovement(matrix);

                if (command == 'U')
                {
                    row = row + 1;
                    if (nikoladzeRow == row)
                    {
                        matrix[nikoladzeRow, nikoladzeCol] = 'X';
                        matrix[row, col] = 'P';
                        Console.WriteLine("Nikoladze killed!");
                    }
                    

                }
                else if (command == 'D')
                {
                    row = row - 1;

                }
                else if (command == 'L')
                {
                    col = col + 1;

                }
                else if (command == 'R')
                {
                    col = col - 1;

                }
                else if (command == 'W')
                {

                }
            }

        }
        public static int[,] EnemyMovement(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == 'b')
                    {
                        if (rows > 0 && )
                    }
                    else if (matrix[rows, cols] == 'd')
                    {

                    }
                }
            }
          return matrix;
        }

        public static bool IsThereEnemy(int[,] matrix, int playerRow, int playerCol)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == 'b')
                    {
                        if (rows == playerRow)
                        {
                            if (cols < playerCol)
                            {
                                return false;
                            }
                        }
                    }
                    else if (matrix[rows, cols] == 'd')
                    {
                        if (rows == playerRow)
                        {
                            if (cols > playerCol)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }



        public void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    } 
}
