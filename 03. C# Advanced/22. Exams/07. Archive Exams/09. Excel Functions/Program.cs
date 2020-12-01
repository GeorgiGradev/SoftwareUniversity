using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelFunctions
{
    public class StartUp
    {
        static string[][] matrix;

        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            matrix = new string[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                matrix[row] = input;
            }

            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string cmdArgs = command[0];
            string header = command[1];

            int headerIndex = Array.IndexOf(matrix[0], header);

            if (cmdArgs == "hide")
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    List<string> lineToPrint = new List<string>(matrix[row]);

                    lineToPrint.RemoveAt(headerIndex);

                    Console.WriteLine(string.Join(" | ", lineToPrint));

                    matrix[row] = lineToPrint.ToArray();
                }

            }
            else if (cmdArgs == "sort")
            {
                string[] headerRow = matrix[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                matrix = matrix.OrderBy(x => x[headerIndex]).ToArray();

                foreach (var row in matrix)
                {
                    if (row != headerRow)
                    {
                        Console.WriteLine(string.Join(" | ", row));
                    }
                }
            }
            else if (cmdArgs == "filter")
            {
                string value = command[2];
                string[] headerRow = matrix[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][headerIndex] == value)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row]));
                    }
                }
            }
        }
    }
}