using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            for (int i = 1; i <= num; i++)
            {
                int newNum = i;
                int sum = 0;
                while (newNum > 0)
                {
                    sum += newNum % 10;
                    newNum = newNum / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }

        }
    }
}
