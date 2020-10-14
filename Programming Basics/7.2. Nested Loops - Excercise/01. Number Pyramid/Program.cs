using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int rows = 0;
            int cols = 0;
            int counter = 0;

            for (rows = 1; rows <= num; rows++)
            {
                for (cols = 1; cols <= rows; cols++)
                {
                    counter++;
                    Console.Write($"{counter} ");
                    if (counter == num)
                    {
                        break;
                    }
                }
                if (counter == num)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
