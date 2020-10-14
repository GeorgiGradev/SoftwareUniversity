using System;

namespace _03._07._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractInYears = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            bool isAddedNet = Console.ReadLine() == "yes";
            int months = int.Parse(Console.ReadLine());

            double monthlyTax = 0;

            switch (contractInYears)
            {
                case "one":
                    {
                        if (typeOfContract == "Small")
                        {
                            monthlyTax = 9.98;
                        }
                        else if (typeOfContract == "Middle")
                        {
                            monthlyTax = 18.99;
                        }
                        else if (typeOfContract == "Large")
                        {
                            monthlyTax = 25.98;
                        }
                        else if (typeOfContract == "ExtraLarge")
                        {
                            monthlyTax = 35.99;
                        }
                        break;
                    }
                case "two":
                    {
                        if (typeOfContract == "Small")
                        {
                            monthlyTax = 8.58;
                        }
                        else if (typeOfContract == "Middle")
                        {
                            monthlyTax = 17.09;
                        }
                        else if (typeOfContract == "Large")
                        {
                            monthlyTax = 23.59;
                        }
                        else if (typeOfContract == "ExtraLarge")
                        {
                            monthlyTax = 31.79;
                        }
                        break;
                    }
            }
            if (isAddedNet)
            {
                if (monthlyTax <= 10)
                {
                    monthlyTax += 5.50;
                }
                else if (monthlyTax > 10 && monthlyTax <= 30)
                {
                    monthlyTax += 4.35;
                }
                else
                {
                    monthlyTax += 3.85;
                }
            }

            double total = monthlyTax * months;

            if (contractInYears == "two")
            {
                total *= 0.9625;
            }
            Console.WriteLine($"{total:F2} lv.");
        }
    }
}
