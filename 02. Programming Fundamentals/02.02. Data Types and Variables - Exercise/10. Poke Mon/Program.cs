using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int factorY = int.Parse(Console.ReadLine());
            int count = 0;
            int originalValue = powerN;

            while (powerN >= distanceM)
            {
                count++;
                powerN -= distanceM;
                if (powerN == originalValue / 2)
                {
                    if (powerN % (originalValue / 2) == 0 && factorY > 0)
                    {
                        powerN /= factorY;
                    }
                }
                if (powerN < 0)
                {
                    count--;
                }
            }
            Console.WriteLine(powerN);
            Console.WriteLine(count);
        }
    }
}
