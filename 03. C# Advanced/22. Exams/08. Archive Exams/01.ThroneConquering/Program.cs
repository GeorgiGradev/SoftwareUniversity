using System;
using System.Data;

namespace _01.ThroneConquering
{
    class Program
    {
        public static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int row = 0;
            int col = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'P')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                int newEnemyRow = int.Parse(input[1]);
                int newEnemyCol = int.Parse(input[2]);
                matrix[newEnemyRow, newEnemyCol] = 'S';

                // P => player character
                // S => Spartan enemy
                // H => Throne
                // - => Empty space

                matrix[row, col] = '-';
                energy -= 1;

                if (command == "up")
                {
                    row = row - 1; // движи се

                    if (row >= 0 || row < n || col >= 0 || col < n) // остава в матрицата
                    {
                        if (matrix[row, col] == 'S') // попада на Enemy
                        {
                            energy -= 2;
                            if (energy >= 0)
                            {
                                matrix[row, col] = '-'; // Enemy изчезва от полето
                            }
                        }
                        else if (matrix[row, col] == 'H') // печели и изчезва от матрицата
                        {
                            Console.WriteLine($"Paris has successfully sat on the throne! Energy left: {energy}");
                            break;
                        }
                    }
                    else // излиза извън матрицата
                    {
                        row = row + 1;
                    }
                }
                else if (command == "down")
                {
                    row = row + 1;

                    if (row >= 0 && row < n && col >= 0 && col < n) // остава в матрицата
                    {
                        if (matrix[row, col] == 'S') // попада на Enemy
                        {
                            energy -= 2;
                            if (energy >= 0)
                            {
                                matrix[row, col] = '-'; // Enemy изчезва от полето
                            }
                        }
                        else if (matrix[row, col] == 'H') // печели и изчезва от матрицата
                        {
                            Console.WriteLine($"Paris has successfully sat on the throne! Energy left: {energy}");
                            break;
                        }
                    }
                    else // излиза извън матрицата
                    {
                        row = row - 1;
                    }
                }
                else if (command == "left")
                {
                    col = col - 1;

                    if (row >= 0 && row < n && col >= 0 && col < n) // остава в матрицата
                    {
                        if (matrix[row, col] == 'S') // попада на Enemy
                        {
                            energy -= 2;
                            if (energy >= 0)
                            {
                                matrix[row, col] = '-'; // Enemy изчезва от полето
                            }
                        }
                        else if (matrix[row, col] == 'H') // печели и изчезва от матрицата
                        {
                            Console.WriteLine($"Paris has successfully sat on the throne! Energy left: {energy}");
                            break;
                        }
                    }
                    else // излиза извън матрицата
                    {
                        col = col + 1;
                    }
                }
                else if (command == "right")
                {
                    col = col + 1;
                    if (row >= 0 && row < n && col >= 0 && col < n) // остава в матрицата
                    {
                        if (matrix[row, col] == 'S') // попада на Enemy
                        {
                            energy -= 2;
                            if (energy >= 0)
                            {
                                matrix[row, col] = '-'; // Enemy изчезва от полето
                            }
                        }
                        else if (matrix[row, col] == 'H') // печели и изчезва от матрицата
                        {
                            Console.WriteLine($"Paris has successfully sat on the throne! Energy left: {energy}");
                            break;
                        }
                    }
                    else // излиза извън матрицата
                    {
                        col = col - 1;
                    }
                }

                if (energy <= 0)
                {
                    Console.WriteLine($"Paris died at {row};{col}."); // GAME OVER 
                    matrix[row, col] = 'X';
                    break;
                }
            }
            PrintMatrix(matrix, n); 
        }

        static void PrintMatrix(char[,] matrix, int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write($"{matrix[rows, cols]}");
                }
                Console.WriteLine();
            }
        }
    }
}