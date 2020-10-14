using System;

namespace _08._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            double voucher = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double price = 0;

            int counterOthers = 0;
            int counterTickets = 0;

            while (command != "End")
            {
                if (command.Length > 8)
                {
                    price = command[0] + command[1];
                    voucher -= price;
                    if (voucher >= 0)
                    {
                        counterTickets++;
                    }
                }
                else
                {
                    price = command[0];
                    voucher -= price;
                    if (voucher > 0)
                    {
                        counterOthers++;
                    }
                }
                if (voucher < 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(counterTickets);
            Console.WriteLine(counterOthers);
        }
    }
}
