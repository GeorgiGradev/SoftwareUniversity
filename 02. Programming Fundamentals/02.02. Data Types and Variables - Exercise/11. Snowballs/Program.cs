using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger count = BigInteger.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            BigInteger snowballQuality = 0;
            BigInteger bestQuality = 0;
            BigInteger bestValue = 0;
            BigInteger bestSnow = 0;
            BigInteger bestTime = 0;

            for (BigInteger i = 0; i < count; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = BigInteger.Parse(Console.ReadLine());


                snowballValue = BigInteger.Pow(snowballSnow / snowballTime, (int)snowballQuality);
                if (snowballValue > bestValue)
                {
                    bestQuality = snowballQuality;
                    bestValue = snowballValue;
                    bestTime = snowballTime;
                    bestSnow = snowballSnow;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
