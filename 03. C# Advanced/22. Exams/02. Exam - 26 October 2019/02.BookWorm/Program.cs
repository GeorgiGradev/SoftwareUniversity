using System;
using System.ComponentModel.Design;
using System.Data;

namespace REDO_2.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int row = 0;
            int col = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string currentLine = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = currentLine[cols];
                    if (matrix[rows, cols] == 'P')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }
            // If he moves to a letter, he consumes it, concatеnates it to the initial string and the letter disappears from the field. 

            // If he tries to move outside of the field, he is punished - he loses the last letter in the string, if there are any, and the player’s position is not changed.
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                matrix[row, col] = '-'; // оставя '-' на предишната клетла

                if (command == "up")
                {
                    row -= 1;
                    if ((row < 0 || row >= n || col < 0 || col >= n)) // излиза от матрицата
                    {
                        row += 1;
                        if (text.Length > 0)
                        {
                            text = text.Remove(text.Length - 1, 1);
                        }
                    }
                    else if (Char.IsLetter(matrix[row, col])) // удря буква
                    {
                        text = text + matrix[row, col];
                    }
                }
                else if (command == "down")
                {
                    row += 1;
                    if ((row < 0 || row >= n || col < 0 || col >= n)) // излиза от матрицата
                    {
                        row -= 1;
                        if (text.Length > 0)
                        {
                            text = text.Remove(text.Length - 1, 1);
                        }
                    }
                    else if (Char.IsLetter(matrix[row, col])) // удря буква
                    {
                        text = text + matrix[row, col];
                    }
                }
                else if (command == "left")
                {
                    col -= 1;
                    if ((row < 0 || row >= n || col < 0 || col >= n)) // излиза от матрицата
                    {
                        col += 1;
                        if (text.Length > 0)
                        {
                            text = text.Remove(text.Length - 1, 1);
                        }
                    }
                    else if (Char.IsLetter(matrix[row, col])) // удря буква
                    {
                        text = text + matrix[row, col];
                    }
                }
                else if (command == "right")
                {
                    col += 1;
                    if ((row < 0 || row >= n || col < 0 || col >= n)) // излиза от матрицата
                    {
                        col -= 1;
                        if (text.Length > 0)
                        {
                            text = text.Remove(text.Length - 1, 1);
                        }
                    }
                    else if (Char.IsLetter(matrix[row, col])) // удря буква
                    {
                        text = text + matrix[row, col];
                    }
                }
                matrix[row, col] = 'P';
            }
            Console.WriteLine(text);
            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
