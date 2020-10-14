using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWM = double.Parse(Console.ReadLine());
            int Price1toy = int.Parse(Console.ReadLine());

            double receivedMoney = 0;
            double moneyFromToys = 0;
            double totalSaved = 0;
            double totalLeft = 0;
            double totalReceivedMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    moneyFromToys = moneyFromToys + Price1toy;
                }
                else if (i % 2 == 0)
                {
                    receivedMoney = 10 + receivedMoney;
                    totalReceivedMoney = receivedMoney + totalReceivedMoney - 1;
                }
               
            }

            totalSaved = totalReceivedMoney + moneyFromToys;
            double diff = Math.Abs(totalSaved - priceWM);

            if (totalSaved >= priceWM)
            {
                Console.WriteLine($"Yes! {diff:F2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:F2}"); 
            }

        }
    }
}
