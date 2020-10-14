using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int freightNumber = int.Parse(Console.ReadLine());
            int totalMicrobus = 0;
            int totalTruck = 0;
            int totalTrain = 0;
            int totalTonnage = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;


            for (int i = 0; i < freightNumber; i++)
            {
                int tonnage = int.Parse(Console.ReadLine());
                if (tonnage <= 3)
                {
                    totalMicrobus = totalMicrobus + (200 * tonnage);
                    count1 = count1 + tonnage;
                }
                else if (tonnage > 3 && tonnage <=11)
                {
                    totalTruck = totalTruck + (175 * tonnage);
                    count2 = count2 + tonnage;
                }
                else if (tonnage > 11)
                {
                    totalTrain = totalTrain + (120 * tonnage);
                    count3 = count3 + tonnage;
                }
            }
            totalTonnage = count1 + count2 + count3;
            double tonnagePrice = (totalMicrobus + totalTrain + totalTruck) * 1.0 / totalTonnage;
            double percentMicrobus = count1 * 1.0 / totalTonnage * 100;
            double percentTruck = count2 * 1.0 / totalTonnage * 100;
            double percentTrain = count3 * 1.0 / totalTonnage * 100;

            Console.WriteLine($"{tonnagePrice:F2}");
            Console.WriteLine($"{percentMicrobus:F2}%");
            Console.WriteLine($"{percentTruck:F2}%");
            Console.WriteLine($"{percentTrain:F2}%");

        }
    }
}
