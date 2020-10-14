using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {

            double income = double.Parse(Console.ReadLine());
            double performance = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = minSalary * 0.35;
            double performanceScholarship = 25 * performance;


            if (performance >= 5.5 & income < minSalary)
            {
                if (socialScholarship > performanceScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else if (socialScholarship <= performanceScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(performanceScholarship)} BGN");
                }
            }

            else if (performance > 4.5 && performance < 5.5)

            {
                if (income < minSalary)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else if (income > minSalary)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            
            else if (performance >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(performanceScholarship)} BGN");
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
