using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    for (char l1 = 'a'; l1 < 'a' + L; l1++)
                    {
                        for (char l2 = 'a'; l2 < 'a' + L; l2++)
                        {
                            for (int m = 0; m <= n; m++)
                            {
                                if (m > i && m > k)
                                {
                                    Console.Write($"{i}{k}{l1}{l2}{m} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
