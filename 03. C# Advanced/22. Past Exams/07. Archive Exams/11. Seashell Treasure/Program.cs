using System;
using System.Collections.Generic;
using System.Linq;

namespace SeashellTreasure
{
    class StartUp
    {
        static char[][] matrix;
        static int GullyRow;
        static int GullyCol;
        static int stolenSeashells;

        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                matrix[row] = input;
            }

            List<char> collectedSeashell = new List<char>();

            string command = Console.ReadLine();

            while (command != "Sunset")
            {
                string[] commandArgument = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command.StartsWith("Collect "))
                {
                    int row = int.Parse(commandArgument[1]);
                    int col = int.Parse(commandArgument[2]);

                    if (IsInside(row, col) && char.IsLetter(matrix[row][col]))
                    {
                        collectedSeashell.Add(matrix[row][col]);
                        matrix[row][col] = '-';
                    }
                }
                if (command.StartsWith("Steal "))
                {
                    int row = int.Parse(commandArgument[1]);
                    int col = int.Parse(commandArgument[2]);
                    string direction = commandArgument[3];

                    if (IsInside(row, col))
                    {
                        if (char.IsLetter(matrix[row][col]))
                        {
                            stolenSeashells++;
                            matrix[row][col] = '-';

                            GullyRow = row;
                            GullyCol = col;

                            for (int i = 0; i < 3; i++)
                            {
                                switch (direction)
                                {
                                    case "up": Move(-1, 0); break;
                                    case "down": Move(1, 0); break;
                                    case "left": Move(0, -1); break;
                                    case "right": Move(0, 1); break;
                                }
                            }
                        }
                    }

                }

                command = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.Write($"Collected seashells: {collectedSeashell.Count}");

            if (collectedSeashell.Count != 0)
            {
                Console.WriteLine($" -> {string.Join(", ", collectedSeashell)}");
            }
            else
            {
                Console.WriteLine();
            }

            Console.WriteLine($"Stolen seashells: {stolenSeashells}");
        }

        private static void Move(int row, int col)
        {

            if (IsInside(GullyRow + row, GullyCol + col))
            {
                GullyRow += row;
                GullyCol += col;

                if (char.IsLetter(matrix[GullyRow][GullyCol]))
                {
                    stolenSeashells++;
                    matrix[GullyRow][GullyCol] = '-';
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