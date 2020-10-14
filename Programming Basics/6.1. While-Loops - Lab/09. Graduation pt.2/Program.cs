using System;

namespace _09._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int count = 0;
            int newCount = 0;

            while (count < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                
                if (grade >= 4)
                {
                    sum += grade;
                    count++;
                }
                if (grade < 4)
                {
                    if (newCount < 1)
                    {
                        count++;
                        newCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been excluded at {count} grade");
                        return;
                    }
                }
            }
            if (count == 12)
            {
                double averageGrade = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
