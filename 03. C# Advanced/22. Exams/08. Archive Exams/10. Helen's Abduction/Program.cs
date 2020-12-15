using System;
using System.Linq;

namespace HelenAbduction
{
    public class StartUp
    {
        static char[][] matrix;
        static int parisRow;
        static int parisCol;
        static int parisEnergy;

        public static void Main()
        {
            parisEnergy = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());

            matrix = new char[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                matrix[row] = input;
            }

            FindparisCoordinates();

            while (true)
            {
                string[] inputCommand = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int spawnRow = int.Parse(inputCommand[1]);
                int spawnCol = int.Parse(inputCommand[2]);

                matrix[spawnRow][spawnCol] = 'S';

                string direction = inputCommand[0];

                switch (direction)
                {
                    case "up": Move(-1, 0); break;
                    case "down": Move(1, 0); break;
                    case "left": Move(0, -1); break;
                    case "right": Move(0, 1); break;
                    default:
                        break;
                }
            }
        }

        private static void FindparisCoordinates()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                }
            }
        }

        private static void Printmatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(string.Join("", matrix[row]));
            }
        }

        private static void Move(int row, int col)
        {
            if (IsInside(parisRow + row, parisCol + col))
            {
                if (matrix[parisRow][parisCol] == 'P')
                {
                    matrix[parisRow][parisCol] = '-';
                }

                parisRow += row;
                parisCol += col;

                parisEnergy--;

                if (matrix[parisRow][parisCol] == 'H')
                {
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
                    matrix[parisRow][parisCol] = '-';
                    Printmatrix();
                    Environment.Exit(0);
                }

                if (parisEnergy <= 0)
                {
                    matrix[parisRow][parisCol] = 'X';
                    Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                    Printmatrix();
                    Environment.Exit(0);
                }

                if (matrix[parisRow][parisCol] == 'S')
                {
                    parisEnergy -= 2;

                    if (parisEnergy <= 0)
                    {
                        matrix[parisRow][parisCol] = 'X';
                        Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                        Printmatrix();
                        Environment.Exit(0);
                    }
                    else
                    {
                        matrix[parisRow][parisCol] = '-';
                    }
                }
            }
            else
            {
                parisEnergy--;
            }
        }

        public static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.Length &&
                   col >= 0 && col < matrix[row].Length;
        }
    }
}