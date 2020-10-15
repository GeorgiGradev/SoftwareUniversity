using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }

            else
            {
                Console.WriteLine($"{Math.Round(salary)}");
            }
        }
    }
}

