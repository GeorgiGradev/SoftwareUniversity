using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeIn1meter = double.Parse(Console.ReadLine());

            double slowingTime = Math.Floor(distance / 15) * 12.5;
            

            double ivanTime = (distance * timeIn1meter) + slowingTime;
            double difference = ivanTime - record;

            if (ivanTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:F2} seconds.");
            }
            else if (record <= ivanTime)
            {
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }

        }

        }
    }
