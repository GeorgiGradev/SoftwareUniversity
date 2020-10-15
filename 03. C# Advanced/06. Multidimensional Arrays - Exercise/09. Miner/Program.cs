using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            char[,] matrix = new char[n, n];
            int minerPositionRow = 0;
            int minerPositionCol = 0;
            int coalCount = 0;
            int coalsAtBeginning = 0;

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (currentRow[col] == 's')
                    {
                        minerPositionRow = row;
                        minerPositionCol = col;
                    }
                    else if (currentRow[col] == 'c')
                    {
                        coalsAtBeginning++;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    if (minerPositionRow - 1 >= 0)
                    {
                        if (matrix[minerPositionRow -1, minerPositionCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({ minerPositionRow - 1}, {minerPositionCol})");
                            return;
                        }
                        else if ((matrix[minerPositionRow - 1, minerPositionCol] == 'c'))
                        {
                            coalCount++;
                        }
                        matrix[minerPositionRow, minerPositionCol] = '*';
                        minerPositionRow = minerPositionRow - 1;
                    }
                }
                else if (commands[i] == "down")
                {
                    if (minerPositionRow + 1 < n)
                    {
                        if (matrix[minerPositionRow + 1, minerPositionCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({ minerPositionRow + 1}, {minerPositionCol})");
                            return;
                        }
                        else if ((matrix[minerPositionRow + 1, minerPositionCol] == 'c'))
                        {
                            coalCount++;
                        }
                        matrix[minerPositionRow, minerPositionCol] = '*';
                        minerPositionRow = minerPositionRow + 1;
                    }
                }
                else if (commands[i] == "left")
                {
                    if (minerPositionCol - 1 >= 0)
                    {
                        if (matrix[minerPositionRow, minerPositionCol - 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({ minerPositionRow}, {minerPositionCol - 1})");
                            return;
                        }
                        else if ((matrix[minerPositionRow, minerPositionCol - 1] == 'c'))
                        {
                            coalCount++;
                        }
                        matrix[minerPositionRow, minerPositionCol] = '*';
                        minerPositionCol = minerPositionCol - 1;
                    }
                }
                else if (commands [i] == "right")
                {
                    if (minerPositionCol + 1 < n)
                    {
                        if (matrix[minerPositionRow, minerPositionCol + 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({ minerPositionRow}, {minerPositionCol + 1})");
                            return;
                        }
                        else if ((matrix[minerPositionRow, minerPositionCol + 1] == 'c'))
                        {
                            coalCount++;
                        }
                        matrix[minerPositionRow, minerPositionCol] = '*';
                        minerPositionCol = minerPositionCol + 1;
                    }
                }
                if (coalsAtBeginning == coalCount)
                {
                    Console.WriteLine($"You collected all coals! ({minerPositionRow}, {minerPositionCol})");
                    return;
                }
            }
            Console.WriteLine($"{coalsAtBeginning - coalCount} coals left. ({minerPositionRow}, {minerPositionCol})");
        }
    }
}
