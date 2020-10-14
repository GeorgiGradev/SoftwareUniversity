using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int a = 1; a <= men; a++)
            {
                for (int b = 1; b <= women; b++)
                {
                    counter++;
                    while (counter <= tables)
                    {
                        Console.Write($"({a} <-> {b}) ");
                        break;
                    }
                    
                }
            }

        }
    }
}
