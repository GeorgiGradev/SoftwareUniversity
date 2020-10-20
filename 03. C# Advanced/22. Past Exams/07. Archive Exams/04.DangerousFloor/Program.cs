using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char[,] matrix = new char[8, 8];

        ReadMatrix(matrix);

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            char pieceType = input[0];
            int currentPositionRow = input[1] - '0';
            int currentPositionCol = input[2] - '0';
            int nextPositionRow = input[4] - '0';
            int nextPositionCol = input[5] - '0';

            if (matrix[currentPositionRow, currentPositionCol] != pieceType)
            {
                Console.WriteLine("There is no such a piece!");
                continue;
            }
            if (CheckIsMoveValid(matrix, new int[] { currentPositionRow, currentPositionCol }, new int[] { nextPositionRow, nextPositionCol }) == false)
            {
                Console.WriteLine("Invalid move!");
                continue;
            }
            if (nextPositionRow >= matrix.GetLength(0) || nextPositionCol >= matrix.GetLength(1) || nextPositionRow < 0 || nextPositionCol < 0)
            {
                Console.WriteLine("Move go out of board!");
                continue;
            }

            MovePiece(matrix, new int[] { currentPositionRow, currentPositionCol }, new int[] { nextPositionRow, nextPositionCol });
        }
    }

    static void ReadMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] input = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = input[col];
            }
        }
    }

    static void MovePiece(char[,] matrix, int[] currentPosition, int[] nextPosition)
    {
        char piece = matrix[currentPosition[0], currentPosition[1]];
        matrix[currentPosition[0], currentPosition[1]] = 'x';
        matrix[nextPosition[0], nextPosition[1]] = piece;
    }

    static bool CheckIsMoveValid(char[,] matrix, int[] currentPosition, int[] nextPosition)
    {
        bool isValid = false;
        char piece = matrix[currentPosition[0], currentPosition[1]];

        if (piece == 'K')
        {
            if (new int[] { currentPosition[0], currentPosition[1] + 1 }.SequenceEqual(nextPosition) ||
                new int[] { currentPosition[0] + 1, currentPosition[1] + 1 }.SequenceEqual(nextPosition) ||
                new int[] { currentPosition[0] + 1, currentPosition[1] }.SequenceEqual(nextPosition) ||
                new int[] { currentPosition[0], currentPosition[1] - 1 }.SequenceEqual(nextPosition) ||
                new int[] { currentPosition[0] - 1, currentPosition[1] - 1 }.SequenceEqual(nextPosition) ||
                new int[] { currentPosition[0] - 1, currentPosition[1] }.SequenceEqual(nextPosition) ||
                new int[] { currentPosition[0] - 1, currentPosition[1] + 1 }.SequenceEqual(nextPosition) ||
                new int[] { currentPosition[0] + 1, currentPosition[1] - 1 }.SequenceEqual(nextPosition))
            {
                isValid = true;
            }
        }
        else if (piece == 'R')
        {
            if (currentPosition[0] == nextPosition[0] || currentPosition[1] == nextPosition[1])
            {
                isValid = true;
            }
        }
        else if (piece == 'B')
        {
            int rowsDiference = Math.Abs(currentPosition[0] - nextPosition[0]);
            int colsDiference = Math.Abs(currentPosition[1] - nextPosition[1]);

            if (rowsDiference == colsDiference)
            {
                isValid = true;
            }
        }
        else if (piece == 'P')
        {
            if (nextPosition[0] - currentPosition[0] == -1 && currentPosition[1] == nextPosition[1])
            {
                isValid = true;
            }
        }
        else if (piece == 'Q')
        {
            if (currentPosition[0] == nextPosition[0] || currentPosition[1] == nextPosition[1])
            {
                isValid = true;
            }
            else
            {
                int rowsDiference = Math.Abs(currentPosition[0] - nextPosition[0]);
                int colsDiference = Math.Abs(currentPosition[1] - nextPosition[1]);

                if (rowsDiference == colsDiference)
                {
                    isValid = true;
                }
            }
        }

        return isValid;
    }
}