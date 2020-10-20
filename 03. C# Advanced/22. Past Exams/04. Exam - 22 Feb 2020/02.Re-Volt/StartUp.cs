using System;
using System.Data;

namespace _02.Re_Volt
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countCommands = int.Parse(Console.ReadLine());
            int row = 0;
            int col = 0;
            char[,] matrix = new char[n, n];
            bool isFInished = false;
            int counter = 0;

            for (int rows = 0; rows < n; rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (input[cols] == 'f')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }
            for (int i = 0; i < countCommands; i++)
            {
                counter++;
                string command = Console.ReadLine();
                if (command == "up")
                {
                    row = row - 1; // приема новите координати
                    if (row >= 0) // остава вътре
                    {
                        if (matrix[row, col] == 'T') // влиза в капан => връша се назад
                        {
                            row = row + 1;
                        }
                        else if (matrix[row, col] == 'B') // удря бонус => прескача напред
                        {
                            matrix[row + 1, col] = '-'; //променя предишната клетка на '-'
                            row = row - 1; // приема новите координати след скока

                            if (row < 0) // ако излезне извън матрицата
                            {
                                row = n - 1; // мести се от другия край
                                if (matrix[row, col] == 'F') // играта свършва 
                                {
                                    matrix[row, col] = 'f'; // маркираме новата позиция с 'f'
                                    isFInished = true; // => TRUE
                                }
                            }
                        }
                        else if (matrix[row, col] == 'F') // играта свършва 
                        {
                            matrix[row, col] = 'f'; // маркираме новата позиция с 'f'
                            matrix[row + 1, col] = '-'; //променя предишната клетка на '-'
                            isFInished = true; // => TRUE
                        }
                        else
                        {
                            matrix[row + 1, col] = '-'; //променя предишната клетка на '-'
                        }
                    }
                    else // излиза извън матрицата и се мести от другата страна
                    {
                        row = n - 1;
                    }
                }
                else if (command == "down")
                {
                    row = row + 1; // приема новите координати
                    if (row < n) // остава вътре
                    {
                        if (matrix[row, col] == 'T') // влиза в капан => връша се назад
                        {
                            row = row - 1;
                        }
                        else if (matrix[row, col] == 'B') // удря бонус => прескача напред
                        {
                            matrix[row - 1, col] = '-'; //променя предишната клетка на '-'
                            row = row + 1; // приема новите координати след скока

                            if (row >= n) // ако излезне извън матрицата
                            {
                                row = 0; // мести се от другия край
                                if (matrix[row, col] == 'F') // играта свършва 
                                {
                                    matrix[row, col] = 'f'; // маркираме новата позиция с 'f'
                                    isFInished = true; // => TRUE
                                }
                            }
                        }
                        else if (matrix[row, col] == 'F') // играта свършва 
                        {
                            matrix[row, col] = 'f'; // маркираме новата позиция с 'f'
                            matrix[row - 1, col] = '-'; //променя предишната клетка на '-'
                            isFInished = true; // => TRUE
                        }
                        else
                        {
                            matrix[row - 1, col] = '-'; //променя предишната клетка на '-'
                        }
                    }
                    else // излиза извън матрицата и се мести от другата страна
                    {
                        row = 0;
                    }
                }
                else if (command == "left")
                {
                    col = col - 1; // приема новите координати
                    if (col >= 0) // остава вътре
                    {
                        if (matrix[row, col] == 'T') // влиза в капан => връша се назад
                        {
                            col = col + 1;
                        }
                        else if (matrix[row, col] == 'B') // удря бонус => прескача напред
                        {
                            matrix[row, col + 1] = '-'; //променя предишната клетка на '-'
                            col = col - 1; // приема новите координати след скока

                            if (col < 0) // ако излезне извън матрицата
                            {
                                col = n - 1; // мести се от другия край
                                if (matrix[row, col] == 'F') // играта свършва 
                                {
                                    matrix[row, col] = 'f'; // маркираме новата позиция с 'f'
                                    isFInished = true; // => TRUE
                                }
                            }
                        }
                        else if (matrix[row, col] == 'F') // играта свършва 
                        {
                            matrix[row, col] = 'f'; // маркираме новата позиция с 'f'
                            matrix[row, col + 1] = '-'; //променя предишната клетка на '-'
                            isFInished = true; // => TRUE
                        }
                        else
                        {
                            matrix[row, col + 1] = '-'; //променя предишната клетка на '-'
                        }
                    }
                    else // излиза извън матрицата и се мести от другата страна
                    {
                        col = n - 1;
                    }
                }
                else if (command == "right")
                {
                    col = col + 1; // приема новите координати
                    if (col < n) // остава вътре
                    {
                        if (matrix[row, col] == 'T') // влиза в капан => връша се назад
                        {
                            col = col - 1;
                        }
                        else if (matrix[row, col] == 'B') // удря бонус => прескача напред
                        {
                            matrix[row, col - 1] = '-'; //променя предишната клетка на '-'
                            col = col + 1; // приема новите координати след скока

                            if (col >= n) // ако излезне извън матрицата
                            {
                                col = 0; // мести се от другия край
                                if (matrix[row, col] == 'F') // играта свършва 
                                {
                                    matrix[row, col] = 'f'; // маркираме новата позиция с 'f'
                                    isFInished = true; // => TRUE
                                }
                            }
                        }
                        else if (matrix[row, col] == 'F') // играта свършва 
                        {
                            matrix[row, col] = 'f'; // маркираме новата позиция с 'f'
                            matrix[row, col - 1] = '-'; //променя предишната клетка на '-'
                            isFInished = true; // => TRUE
                        }
                        else
                        {
                            matrix[row, col - 1] = '-'; //променя предишната клетка на '-'
                        }
                    }
                    else // излиза извън матрицата и се мести от другата страна
                    {
                        col = 0;
                    }

                }
                if (isFInished)
                {
                    break;
                }
                if (counter == countCommands)
                {
                    matrix[row, col] = 'f';
                }
            }

            // f => PLayer
            // - => Empty cell
            // B => Bonus (една клетка в същата посока) => не се променя след стъпване
            // T => Trap (една клетка в обратната посока) => не се променя след стъпване
            // F => Finish => isFinished = true
            // ако напусне полето се връща от другата страна

            if (isFInished)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            PrintMatrix(n, matrix);
        }

        private static void PrintMatrix(int n, char[,] matrix)
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
