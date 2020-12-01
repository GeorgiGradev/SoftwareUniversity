using System;

namespace _02.TronRacers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int rowOne = 0;
            int colOne = 0;
            int rowTwo = 0;
            int colTwo = 0;

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'f')
                    {
                        rowOne = row;
                        colOne = col;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        rowTwo = row;
                        colTwo = col;
                    }
                }
            }
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandPlayer1 = input[0];
                string commandPlayer2 = input[1];

                if (commandPlayer1 == "up")
                {
                    if (rowOne - 1 >= 0) // ако остане в матрицата
                    {
                        if (matrix[rowOne - 1, colOne] == '*') // ако няма обект
                        {
                            matrix[rowOne - 1, colOne] = 'f';
                        }
                        else if (matrix[rowOne - 1, colOne] == 's') // ако срещне другият играч
                        {
                            matrix[rowOne - 1, colOne] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        rowOne = rowOne - 1; // нов координат в матрицата
                    }
                    else // ако напусне матрицата
                    {
                        if (matrix[n - 1, colOne] == 's') // ако срещне другият играч
                        {
                            matrix[n - 1, colOne] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        rowOne = n - 1; // мести се от другата страна
                        matrix[rowOne, colOne] = 'f';
                    }
                }
                else if (commandPlayer1 == "down")
                {
                    if (rowOne + 1 < n) // ако остане в матрицата
                    {
                        if (matrix[rowOne + 1, colOne] == '*') // ако няма обект
                        {
                            matrix[rowOne + 1, colOne] = 'f';
                        }
                        else if (matrix[rowOne + 1, colOne] == 's') // ако срещне другият играч
                        {
                            matrix[rowOne + 1, colOne] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        rowOne = rowOne + 1; // нов координат в матрицата
                    }
                    else // ако напусне матрицата
                    {
                        if (matrix[0, colOne] == 's') // ако срещне другият играч
                        {
                            matrix[0, colOne] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        rowOne = 0; // мести се от другата страна
                        matrix[rowOne, colOne] = 'f';
                    }
                }
                else if (commandPlayer1 == "right")
                {
                    if (colOne + 1 < n) // ако остане в матрицата
                    {
                        if (matrix[rowOne, colOne + 1] == '*') // ако няма обект
                        {
                            matrix[rowOne, colOne + 1] = 'f';
                        }
                        else if (matrix[rowOne, colOne + 1] == 's') // ако срещне другият играч
                        {
                            matrix[rowOne, colOne + 1] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        colOne = colOne + 1; // нов координат в матрицата
                    }
                    else // ако напусне матрицата
                    {
                        if (matrix[rowOne, 0] == 's') // ако срещне другият играч
                        {
                            matrix[rowOne, 0] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        colOne = 0; // мести се от другата страна
                        matrix[rowOne, colOne] = 'f';
                    }
                }
                else if (commandPlayer1 == "left")
                {
                    if (colOne - 1 >= 0) // ако остане в матрицата
                    {
                        if (matrix[rowOne, colOne - 1] == '*') // ако няма обект
                        {
                            matrix[rowOne, colOne - 1] = 'f';
                        }
                        else if (matrix[rowOne, colOne - 1] == 's') // ако срещне другият играч
                        {
                            matrix[rowOne, colOne - 1] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        colOne = colOne - 1; // нов координат в матрицата
                    }
                    else // ако напусне матрицата
                    {
                        if (matrix[rowOne, n - 1] == 's') // ако срещне другият играч
                        {
                            matrix[rowOne, n - 1] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        colOne = n - 1; // мести се от другата страна
                        matrix[rowOne, colOne] = 'f';
                    }
                }
                if (commandPlayer2 == "up")
                {
                    if (rowTwo - 1 >= 0) // ако остане в матрицата
                    {
                        if (matrix[rowTwo - 1, colTwo] == '*') // ако няма обект
                        {
                            matrix[rowTwo - 1, colTwo] = 's';
                        }
                        else if (matrix[rowTwo - 1, colTwo] == 'f') // ако срещне другият играч
                        {
                            matrix[rowTwo - 1, colTwo] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        rowTwo = rowTwo - 1; // нов координат в матрицата
                    }
                    else // ако напусне матрицата
                    {
                        if (matrix[n - 1, colTwo] == 's') // ако срещне другият играч
                        {
                            matrix[n - 1, colTwo] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        rowTwo = n - 1; // мести се от другата страна
                        matrix[rowTwo, colTwo] = 's';
                    }
                }
                else if (commandPlayer2 == "down")
                {
                    if (rowTwo + 1 < n) // ако остане в матрицата
                    {
                        if (matrix[rowTwo + 1, colTwo] == '*') // ако няма обект
                        {
                            matrix[rowTwo + 1, colTwo] = 's';
                        }
                        else if (matrix[rowTwo + 1, colTwo] == 'f') // ако срещне другият играч
                        {
                            matrix[rowTwo + 1, colTwo] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        rowTwo = rowTwo + 1; // нов координат в матрицата
                    }
                    else // ако напусне матрицата
                    {
                        if (matrix[0, colTwo] == 's') // ако срещне другият играч
                        {
                            matrix[0, colTwo] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        rowTwo = 0; // мести се от другата страна
                        matrix[rowTwo, colTwo] = 's';
                    }
                }
                else if (commandPlayer2 == "right")
                {
                    if (colTwo + 1 < n) // ако остане в матрицата
                    {
                        if (matrix[rowTwo, colTwo + 1] == '*') // ако няма обект
                        {
                            matrix[rowTwo, colTwo + 1] = 's';
                        }
                        else if (matrix[rowTwo, colTwo + 1] == 'f') // ако срещне другият играч
                        {
                            matrix[rowTwo, colTwo + 1] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        colTwo = colTwo + 1; // нов координат в матрицата
                    }
                    else // ако напусне матрицата
                    {
                        if (matrix[rowTwo, 0] == 's') // ако срещне другият играч
                        {
                            matrix[rowTwo, 0] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        colTwo = 0; // мести се от другата страна
                        matrix[rowTwo, colTwo] = 's';
                    }
                }
                else if (commandPlayer2 == "left")
                {
                    if (colTwo - 1 >= 0) // ако остане в матрицата
                    {
                        if (matrix[rowTwo, colTwo - 1] == '*') // ако няма обект
                        {
                            matrix[rowTwo, colTwo - 1] = 's';
                        }
                        else if (matrix[rowTwo, colTwo - 1] == 'f') // ако срещне другият играч
                        {
                            matrix[rowTwo, colTwo - 1] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        colTwo = colTwo - 1; // нов координат в матрицата
                    }
                    else // ако напусне матрицата
                    {
                        if (matrix[rowTwo, n - 1] == 's') // ако срещне другият играч
                        {
                            matrix[rowTwo, n - 1] = 'x'; // оставя Х и играта приключва
                            break;
                        }
                        colTwo = n - 1; // мести се от другата страна
                        matrix[rowTwo, colTwo] = 's';
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}