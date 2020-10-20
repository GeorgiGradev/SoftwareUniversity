using System;
using System.Security.Cryptography.X509Certificates;

namespace _02.Bee
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int row = 0;
            int col = 0;
            int flowers = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'B')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }
            

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                matrix[row, col] = '.'; // променя се предишната клетка на '.'

                if (command == "up")
                {
                    row = row - 1; // стъпва в нова клетка
                    if (row >= 0) // остава в матрицата
                    {
                        if (matrix[row, col] == 'f')
                        {
                            flowers++;
                        }
                        else if (matrix[row, col] == 'O')
                        {
                            matrix[row, col] = '.'; // променя се предишната клетка на '.'
                            row = row - 1; // стъпва в нова клетка

                            if (matrix[row, col] == 'f')
                            {
                                flowers++;
                            }
                        }
                    }
                    else // излиза от матрицата
                    {
                        Console.WriteLine("The bee got lost!");
                        matrix[row + 1, col] = '.'; // променя се предишната клетка на 'B'
                        break;
                    }
                }
                else if (command == "down")
                {
                    row = row + 1; // стъпва в нова клетка
                    if (row < n) // остава в матрицата
                    {
                        if (matrix[row, col] == 'f')
                        {
                            flowers++;
                        }
                        else if (matrix[row, col] == 'O')
                        {
                            matrix[row, col] = '.'; // променя се предишната клетка на '.'
                            row = row + 1; // стъпва в нова клетка

                            if (matrix[row, col] == 'f')
                            {
                                flowers++;
                            }
                        }
                    }
                    else // излиза от матрицата
                    {
                        Console.WriteLine("The bee got lost!");
                        matrix[row - 1, col] = '.'; // променя се предишната клетка на 'B'
                        break;
                    }
                }
                else if (command == "left")
                {
                    col = col - 1; // стъпва в нова клетка
                    if (col >= 0) // остава в матрицата
                    {
                        if (matrix[row, col] == 'f')
                        {
                            flowers++;
                        }
                        else if (matrix[row, col] == 'O')
                        {
                            matrix[row, col] = '.'; // променя се предишната клетка на '.'
                            col = col - 1; // стъпва в нова клетка

                            if (matrix[row, col] == 'f')
                            {
                                flowers++;
                            }
                        }
                    }
                    else // излиза от матрицата
                    {
                        Console.WriteLine("The bee got lost!");
                        matrix[row, col + 1] = '.'; // променя се предишната клетка на 'B'
                        break;
                    }
                }




                else if (command == "right")
                {
                    col = col + 1; // стъпва в нова клетка
                    if (col < n) // остава в матрицата
                    {
                        if (matrix[row, col] == 'f')
                        {
                            flowers++;
                        }
                        else if (matrix[row, col] == 'O')
                        {
                            matrix[row, col] = '.'; // променя се предишната клетка на '.'
                            col = col + 1; // стъпва в нова клетка

                            if (matrix[row, col] == 'f')
                            {
                                flowers++;
                            }
                        }
                    }
                    else // излиза от матрицата
                    {
                        Console.WriteLine("The bee got lost!");
                        matrix[row, col - 1] = '.'; // променя се предишната клетка на 'B'
                        break;
                    }
                }
                matrix[row, col] = 'B'; // променя се настоящата клетка на 'B'
            }




            if (flowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowers} flowers more");
            }


            PrintMatrix(n, matrix);
            //Console.WriteLine($"Row: {row}");
            //Console.WriteLine($"Col: {col}");
            //Console.WriteLine($"Flowers: {flowers}");



            // empty positions => '.'
            // flowers => 'f'
            // bonus => 'O' ===> one move forward and then the bonus disappears



        }

        public static void PrintMatrix(int n, char[,] matrix)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }

    }
}
