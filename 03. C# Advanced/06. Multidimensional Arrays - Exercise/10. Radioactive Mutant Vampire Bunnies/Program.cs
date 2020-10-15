using System;
using System.Linq;
using System.Collections.Generic;

namespace _10_Radio_Active_Mutant_Vampire_Bunnies
{
    class Program
    {
        static char[,] matrix;
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            matrix = new char[input[0], input[1]];

            int rowCheck = 0;
            int colCheck = 0;


            MatrixCreate(ref rowCheck, ref colCheck);

            char[] moves = Console.ReadLine()
                .ToCharArray();

            bool isSuccessMove = false;
            bool isLive = true;

            for (int i = 0; i < moves.Length; i++)
            {
                matrix[rowCheck, colCheck] = '.';

                isSuccessMove = false;

                if (moves[i] == 'R')
                {
                    if (IsValid(rowCheck, colCheck + 1) == true)
                    {
                        if (matrix[rowCheck, colCheck + 1] == '.')
                        {
                            isSuccessMove = true;
                        }
                        else if (matrix[rowCheck, colCheck + 1] == 'B')
                        {
                            isLive = false;
                            isSuccessMove = true;
                        }
                        colCheck = colCheck + 1;
                    }
                }
                else if (moves[i] == 'L')
                {
                    if (IsValid(rowCheck, colCheck - 1) == true)
                    {
                        if (matrix[rowCheck, colCheck - 1] == '.')
                        {
                            isSuccessMove = true;
                        }
                        else if (matrix[rowCheck, colCheck - 1] == 'B')
                        {
                            isLive = false;
                            isSuccessMove = true;
                        }
                        colCheck = colCheck - 1;
                    }
                }
                else if (moves[i] == 'U')
                {
                    if (IsValid(rowCheck - 1, colCheck) == true)
                    {
                        if (matrix[rowCheck - 1, colCheck] == '.')
                        {
                            isSuccessMove = true;
                        }
                        else if (matrix[rowCheck - 1, colCheck] == 'B')
                        {
                            isLive = false;
                            isSuccessMove = true;
                        }
                        rowCheck = rowCheck - 1;
                    }
                }
                else if (moves[i] == 'D')
                {
                    if (IsValid(rowCheck + 1, colCheck) == true)
                    {
                        if (matrix[rowCheck + 1, colCheck] == '.')
                        {
                            isSuccessMove = true;
                        }
                        else if (matrix[rowCheck, colCheck + 1] == 'B')
                        {
                            isLive = false;
                            isSuccessMove = true;
                        }
                        rowCheck = rowCheck + 1;
                    }
                }


                if (isLive == false)
                {
                    BonneyMoves();
                    MatrixPrint();
                    Console.WriteLine($"dead: {rowCheck} {colCheck}");
                    break;
                }
                else if (isSuccessMove == false)
                {
                    BonneyMoves();
                    MatrixPrint();
                    Console.WriteLine($"won: {rowCheck} {colCheck}");
                    break;
                }

                else
                {
                    matrix[rowCheck, colCheck] = 'P';
                    isLive = false;
                    BonneyMoves();

                    isLive = CheckLive(isLive);

                    if (isLive == false)
                    {
                        MatrixPrint();
                        Console.WriteLine($"dead: {rowCheck} {colCheck}");
                        return;
                    }
                }

            }
        }

        private static bool CheckLive(bool isLive)
        {
            foreach (var items in matrix)
            {
                if (items == 'P')
                {
                    isLive = true;
                }
            }

            return isLive;
        }

        private static void MatrixCreate(ref int rowCheck, ref int colCheck)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (currentRow[col] == 'P')
                    {
                        rowCheck = row;
                        colCheck = col;
                    }

                }
            }
        }

        private static bool IsValid(int rowCheck, int colCheck)
        {
            if ((rowCheck >= 0 && rowCheck < matrix.GetLength(0)) && (colCheck >= 0 && colCheck < matrix.GetLength(1)))
            {
                return true;
            }
            return false;
        }

        private static void MatrixPrint()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void BonneyMoves()
        {
            var indexBunnies = new Dictionary<int, List<int>>();
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        indexBunnies.Add(count, new List<int>());
                        indexBunnies[count].Add(row);
                        indexBunnies[count].Add(col);
                        count++;
                    }
                }
            }

            for (int i = 0; i < indexBunnies.Count; i++)
            {
                int row = indexBunnies[i][0];
                int col = indexBunnies[i][1];


                if (IsValid(row - 1, col) == true)
                {
                    matrix[row - 1, col] = 'B';
                }
                if (IsValid(row + 1, col) == true)
                {
                    matrix[row + 1, col] = 'B';
                }
                if (IsValid(row, col - 1) == true)
                {
                    matrix[row, col - 1] = 'B';
                }
                if (IsValid(row, col + 1) == true)
                {
                    matrix[row, col + 1] = 'B';
                }
            }
            indexBunnies.Clear();
        }
    }
}