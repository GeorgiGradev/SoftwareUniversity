using System;

namespace _12._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isTrue = false;
            int aNew = 0;
            int bNew = 0;
            int cNew = 0;
            int dNew = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if ((a < b && c > d) && (a * b) + (c * d) == M)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                counter++;
                                if (counter == 4)
                                {
                                    aNew = a;
                                    bNew = b;
                                    cNew = c;
                                    dNew = d;
                                }
                                isTrue = true;
                            }
                        }
                    }
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("No!");
            }
            else if (counter < 4)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {aNew}{bNew}{cNew}{dNew}");
            }
             
        }
    }
}
