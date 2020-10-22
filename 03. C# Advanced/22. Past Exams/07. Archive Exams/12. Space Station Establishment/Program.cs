using System;

namespace SpaceStationEstablishment
{
    public class StartUp
    {
        static char[][] matrix;
        static int playerRow = -1;
        static int playerCol = -1;
        static int startPowers;

        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            FillMatrix();

            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up": Move(-1, 0); break;
                    case "down": Move(1, 0); break;
                    case "left": Move(0, -1); break;
                    case "right": Move(0, 1); break;
                }
            }
        }

        private static void FillMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                matrix[row] = input;

                if (playerRow == -1)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'S')
                        {
                            playerRow = row;
                            playerCol = col;
                            break;
                        }
                    }
                }
            }
        }

        private static void PrintMatrix()
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void Move(int row, int col)
        {
            if (IsInside(playerRow + row, playerCol + col))
            {
                if (matrix[playerRow][playerCol] == 'S')
                {
                    matrix[playerRow][playerCol] = '-';
                }

                playerRow += row;
                playerCol += col;

                if (matrix[playerRow][playerCol] == 'O')
                {
                    matrix[playerRow][playerCol] = '-';

                    FindBlackHole();
                }

                if (char.IsDigit(matrix[playerRow][playerCol]))
                {

                    int power = matrix[playerRow][playerCol] - 48;
                    startPowers += power;
                    matrix[playerRow][playerCol] = '-';

                    if (startPowers >= 50)
                    {
                        Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                        Console.WriteLine($"Star power collected: {startPowers}");
                        matrix[playerRow][playerCol] = 'S';
                        PrintMatrix();
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
                Console.WriteLine($"Star power collected: {startPowers}");
                matrix[playerRow][playerCol] = '-';
                PrintMatrix();
                Environment.Exit(0);
            }
        }

        private static void FindBlackHole()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'O')
                    {
                        playerRow = row;
                        playerCol = col;
                        matrix[row][col] = '-';
                        return;
                    }
                }
            }
        }

        public static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.Length &&
                   col >= 0 && col < matrix[row].Length;
        }
    }
}