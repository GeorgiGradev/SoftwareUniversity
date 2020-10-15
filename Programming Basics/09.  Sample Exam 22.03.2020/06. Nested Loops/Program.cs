using System;

namespace _06._Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;
            int counter = 0;

            while (num > 0)
            {
                counter++;
                if (counter == 1)
                {
                    a = num % 10;
                    num = num / 10;
                }
                else if (counter == 2)
                {
                    b = num % 10;
                    num = num / 10;
                }
                else if (counter == 3)
                {
                    c = num % 10;
                    num = num / 10;
                }
            }
            for (int x = 1; x <= a; x ++)
            {
                for (int y = 1; y <= b; y++)
                {
                    for (int z = 1; z <= c; z++)
                    {
                        Console.WriteLine($"{x} * {y} * {z} = {x * y * z};");
                    }
                }
            }
        }
    }
}
