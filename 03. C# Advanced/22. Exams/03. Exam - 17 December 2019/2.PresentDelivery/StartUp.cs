using System;
using System.Linq;
using System.Text;

namespace _2.PresentDelivery
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int row = 0;
            int col = 0;
            int niceKidsAtBeginning = 0;

            char[,] matrix = new char[n, n];

            for (int rows = 0; rows < n; rows++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = currentRow[cols];
                    if (matrix[rows, cols] == 'S')
                    {
                        row = rows;
                        col = cols;
                    }
                    else if (matrix[rows, cols] == 'V')
                    {
                        niceKidsAtBeginning++;
                    }
                }
            }

            // S - naughty kid => NO PRESENT
            // V - nice kid => DROP PRESENT  ====> cell becomes "-'
            // C - cookie => ALL KIDS AROUND HIM RECEIVE PRESENTS 

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Christmas morning")
            {
                if (command == "up")
                {
                    if (row - 1 >= 0) // ако е вътре в матрицата
                    {
                        row = row - 1; // мести се на следващата клетка
                        matrix[row + 1, col] = '-'; // предишната клетката става "-"

                        if (matrix[row, col] == 'V')//ако е добро дете
                        {
                            presents--; // => дава подарък
                        }
                        else if (matrix[row, col] == 'C') // ако има COOKIE
                        {
                            presents = CookieMethod(presents, row, col, matrix);
                        }

                        matrix[row, col] = 'S'; // настоящата клетка став "S"
                    }
                }
                else if (command == "down")
                {
                    if (row + 1 < n) // ако е вътре в матрицата
                    {
                        row = row + 1; // мести се на следващата клетка
                        matrix[row - 1, col] = '-'; // предишната клетката става "-"

                        if (matrix[row, col] == 'V')//ако е добро дете
                        {
                            presents--; // => дава подарък
                        }
                        else if (matrix[row, col] == 'C') // ако има COOKIE
                        {
                            presents = CookieMethod(presents, row, col, matrix);
                        }

                        matrix[row, col] = 'S'; // настоящата клетка став "S"
                    }
                }
                else if (command == "left")
                {
                    if (col - 1 >= 0) // ако е вътре в матрицата
                    {
                        col = col - 1; // мести се на следващата клетка
                        matrix[row, col + 1] = '-'; // предишната клетката става "-"

                        if (matrix[row, col] == 'V')//ако е добро дете
                        {
                            presents--; // => дава подарък
                        }
                        else if (matrix[row, col] == 'C') // ако има COOKIE
                        {
                            presents = CookieMethod(presents, row, col, matrix);
                        }

                        matrix[row, col] = 'S'; // настоящата клетка став "S"
                    }
                }

                else if (command == "right")
                {
                    if (col + 1 < n) // ако е вътре в матрицата
                    {
                        col = col + 1; // мести се на следващата клетка
                        matrix[row, col - 1] = '-'; // предишната клетката става "-"

                        if (matrix[row, col] == 'V')//ако е добро дете
                        {
                            presents--; // => дава подарък
                        }
                        else if (matrix[row, col] == 'C') // ако има COOKIE
                        {
                            presents = CookieMethod(presents, row, col, matrix);
                        }

                        matrix[row, col] = 'S'; // настоящата клетка став "S"
                    }
                }
                if (presents == 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }
            }

            PrintMatrix(matrix);
            int kidsLeftWithoutPresent = 0;

            foreach (var item in matrix)
            {
                if (item == 'V')
                {
                    kidsLeftWithoutPresent++;
                }
            }

            if (kidsLeftWithoutPresent == 0)
            {
                Console.WriteLine($"Good job, Santa! {niceKidsAtBeginning} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {kidsLeftWithoutPresent} nice kid/s.");
            }


        }
        

        private static int CookieMethod(int presents, int row, int col, char[,] matrix)
        {
            if (matrix[row - 1, col] == 'V' || matrix[row - 1, col] == 'X')
            {
                presents--;
                matrix[row - 1, col] = '-';
            }

            if (matrix[row + 1, col] == 'V' || matrix[row + 1, col] == 'X')
            {
                presents--;
                matrix[row + 1, col] = '-';
            }

            if (matrix[row, col - 1] == 'V' || matrix[row, col - 1] == 'X')
            {
                presents--;
                matrix[row, col - 1] = '-';
            }

            if (matrix[row, col + 1] == 'V' || matrix[row, col + 1] == 'X')
            {
                presents--;
                matrix[row, col + 1] = '-';
            }


            return presents;
        }

        public static void PrintMatrix(char[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = string.Empty;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    line += matrix[row, col] + " ";
                }
                line.TrimEnd();
                sb.AppendLine(line);

            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}

