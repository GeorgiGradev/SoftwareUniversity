using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
   
            double electricityBill = 0;
            double waterBill = 20;
            double internetBill = 15;
            double totalElectricityBill = 0;

            for (int i = 0; i < months; i++)
            {
                electricityBill = double.Parse(Console.ReadLine());
               totalElectricityBill += electricityBill;
            }

            double total = totalElectricityBill + months * (waterBill + internetBill);
            double others = total * 1.2;
            double avarage = (total + others)/ months;

            Console.WriteLine($"Electricity: {totalElectricityBill:F2} lv");
            Console.WriteLine($"Water: {months * waterBill:F2} lv");
            Console.WriteLine($"Internet: {months * internetBill:F2} lv");
            Console.WriteLine($"Other: {others:F2} lv");
            Console.WriteLine($"Average: {avarage:F2} lv");

        }
    }
}
