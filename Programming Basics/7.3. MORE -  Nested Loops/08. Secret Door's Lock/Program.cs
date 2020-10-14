using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos1 = int.Parse(Console.ReadLine());
            int pos2 = int.Parse(Console.ReadLine());
            int pos3 = int.Parse(Console.ReadLine());

            for (int a = 1; a <= pos1; a++)
            {
                if (a % 2 != 0)
                {
                    continue;
                }
                for (int b = 1; b <= pos2; b++)
                {
                    if (b == 1 || b == 4 || b == 6 || b == 8 || b == 9)
                    {
                        continue;
                    }
                    for (int c = 1; c <= pos3; c++)
                    {
                        if (c % 2 != 0)
                        {
                            continue;
                        }
                        Console.WriteLine($"{a} {b} {c}");
                    }
                }
            }
        }
    }
}