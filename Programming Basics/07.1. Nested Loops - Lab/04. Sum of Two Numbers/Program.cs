using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int i = 0;
            int k = 0;
            bool isFound = false;

            for (i = startNumber; i <= endNumber; i++)
            {
                for (k = startNumber; k <= endNumber; k++)
                {
                    counter++;
                    if (i + k == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {k} = {magicNumber})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound == false)
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
