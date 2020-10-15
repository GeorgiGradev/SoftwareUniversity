using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = start; i <= end; i++)
            {
                if (i == skip)
                {
                    continue;
                }
                for (char k = start; k <= end; k++)
                {
                    if (k == skip)
                    {
                        continue;
                    }
                    for (char l = start; l <= end; l++)
                    {
                        if (l == skip)
                        {
                            continue;
                        }
                       
                        counter++;
                        Console.Write ($"{i}{k}{l} ");

                    }

                }
            }
            Console.Write(counter);
        }
    }
}
