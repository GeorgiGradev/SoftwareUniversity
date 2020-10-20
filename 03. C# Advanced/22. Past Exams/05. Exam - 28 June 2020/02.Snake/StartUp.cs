 using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _02.Snake
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int row = 0;
            int col = 0;
            int food = 0;

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
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                matrix[row, col] = '.';

                if (command == "up")
                {
                    row = row - 1;
                }
                else if (command == "down")
                {
                    row = row + 1;
                }
                else if (command == "left")
                {
                    col = col - 1;
                }
                else if (command == "right")
                {
                    col = col + 1;
                }

                if (IsOutSideMAtrix(n, row, col))
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Food eaten: {food}");
                    break;
                }
                else
                {
                    char symbol = matrix[row, col];
                    if (symbol == '*') //има храна
                    {
                        food++;
                        matrix[row, col] = '.'; // променя настоящата клетка на '.'
                    }
                    else if (symbol == 'B')
                    {
                        matrix[row, col] = '.';
                        for (int rows = 0; rows < n; rows++)
                        {
                            for (int cols = 0; cols < n; cols++)
                            {
                                if (matrix[rows, cols] == 'B')
                                {
                                    row = rows;
                                    col = cols;
                                }
                            }
                        }
                    }

                    if (food >= 10)
                    {
                        Console.WriteLine("You won! You fed the snake.");
                        Console.WriteLine($"Food eaten: {food}");
                        matrix[row, col] = 'S';
                        break;
                    }
                }
            }
            PrintMatrix(n, matrix);

            static bool IsOutSideMAtrix(int n, int row, int col)
            {
                return row >= n || row < 0 || col >= n || col < 0;
            }

            static void PrintMatrix(int n, char[,] matrix)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

