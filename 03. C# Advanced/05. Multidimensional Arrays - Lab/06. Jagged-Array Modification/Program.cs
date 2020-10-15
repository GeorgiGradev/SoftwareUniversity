using System;
using System.Linq;
using System.Security.Cryptography;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = currentRow;
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split();
                int rowToAdd = int.Parse(tokens[1]);
                int colToAdd = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (tokens[0] == "Add")
                {
                    if (rowToAdd >= rows || rowToAdd < 0 || colToAdd < 0 || colToAdd >= jagged[colToAdd].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jagged[rowToAdd][colToAdd] += value;
                    }
                }
                else if (tokens[0] == "Subtract")
                {
                    if (rowToAdd >= rows || rowToAdd < 0 || colToAdd < 0 || colToAdd >= jagged[colToAdd].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jagged[rowToAdd][colToAdd] -= value;
                    }
                }
            }
            foreach (var currentRow in jagged)
            {
                Console.WriteLine(string.Join(" ", currentRow));
            }
        }
    }
}
