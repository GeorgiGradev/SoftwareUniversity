using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries )
                    .ToArray();
                if (commands[0] == "END")
                {
                    break;
                }
                else if (commands[0] != "swap" || commands.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);

                    if (row1 < 0 || col1 < 0 || row2 < 0 || col2 < 0
                        || row1 >= rows || row2 >= rows || col1 >= cols || col2 >= cols)
                    {

                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string perm = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = perm;
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }

        }
    }
}
