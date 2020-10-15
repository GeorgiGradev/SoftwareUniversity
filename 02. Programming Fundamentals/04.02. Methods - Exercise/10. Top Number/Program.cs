using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int temp2 = i;
                bool isOdd = false;
                int sum = 0;
                while (temp2 > 0)
                {
                    int temp = temp2 % 10;
                    if (temp % 2 != 0)
                    {
                        isOdd = true;
                    }
                    sum += temp;
                    temp2 = temp2 / 10;
                }
                if (sum % 8 == 0 && isOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
