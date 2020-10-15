using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            int num = int.Parse(numStr);
            int currentDigit = 0;
            int factoriel = 1;
            int sum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                currentDigit = int.Parse(numStr[i].ToString());
                for (int k = 1; k <= currentDigit; k++)
                {
                    factoriel *= k;
                    
                }
                sum += factoriel;
                factoriel = 1;
            }
            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
