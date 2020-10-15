using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            if (lines == 1)
            {
                return;
            }
            int[] initialArray = new int[] { 1, 1 };
            Console.WriteLine(string.Join(" ", initialArray));
            if (lines == 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < initialArray.Length + 1; i++)
                {
                    int[] newArray = new int[initialArray.Length + 1];
                    newArray[0] = 1;
                    newArray[newArray.Length - 1] = 1;

                    for (int k = 1; k < newArray.Length - 1; k++)
                    {
                        newArray[k] = initialArray[k] + initialArray[k - 1];
                    }
                    Console.WriteLine(string.Join(" ", newArray));

                    initialArray = newArray;

                    if (initialArray.Length == lines)
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}
