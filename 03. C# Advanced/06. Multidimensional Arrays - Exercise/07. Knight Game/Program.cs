using System;
using System.Data;
using System.Linq;

namespace _07._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            char[,] matrix = new char[rows, cols];
            int counter = 0;

            int currentKnightsInDanger = 0;
            int maxKnightsInDanger = 0;
            int mostDangerousKnightRow = 0;
            int mostDangerousKnightCol = 0;



            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            while (true)
            {
                for (int row = 0; row < rows; row++)
                {
                    int col = 0;
                    for (col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            if (row - 1 >= 0 && row - 1 < n && col - 2 >= 0 && col - 2 < n && matrix[row - 1, col - 2] == 'K')
                            {
                                currentKnightsInDanger++;
                            }
                            if (row - 2 >= 0 && row - 2 < n && col - 1 >= 0 && col - 1 < n && matrix[row - 2, col - 1] == 'K')
                            {
                                currentKnightsInDanger++;
                            }
                            if (row - 2 >= 0 && row - 2 < n && col + 1 >= 0 && col + 1 < n && matrix[row - 2, col + 1] == 'K')
                            {
                                currentKnightsInDanger++;
                            }
                            if (row - 1 >= 0 && row - 1 < n && col + 2 >= 0 && col + 2 < n && matrix[row - 1, col + 2] == 'K')
                            {
                                currentKnightsInDanger++;
                            }
                            if (row + 1 >= 0 && row + 1 < n && col + 2 >= 0 && col + 2 < n && matrix[row + 1, col + 2] == 'K')
                            {
                                currentKnightsInDanger++;
                            }
                            if (row + 2 >= 0 && row + 2 < n && col + 1 >= 0 && col + 1 < n && matrix[row + 2, col + 1] == 'K')
                            {
                                currentKnightsInDanger++;
                            }
                            if (row + 2 >= 0 && row + 2 < n && col - 1 >= 0 && col - 1 < n && matrix[row + 2, col - 1] == 'K')
                            {
                                currentKnightsInDanger++;
                            }
                            if (row + 1 >= 0 && row + 1 < n && col - 2 >= 0 && col - 2 < n && matrix[row + 1, col - 2] == 'K')
                            {
                                currentKnightsInDanger++;
                            }
                        }
                        if (currentKnightsInDanger > maxKnightsInDanger)
                        {
                            maxKnightsInDanger = currentKnightsInDanger;
                            mostDangerousKnightRow = row;
                            mostDangerousKnightCol = col;
                        }
                        currentKnightsInDanger = 0;
                    }
                }
                if (maxKnightsInDanger != 0)
                {
                    matrix[mostDangerousKnightRow, mostDangerousKnightCol] = 'O';
                    counter++;
                    maxKnightsInDanger = 0;
                }
                else
                {
                    Console.WriteLine(counter);
                    return;
                }
            }
        }
    }
}
