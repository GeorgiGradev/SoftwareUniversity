using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine());


            int topCounter = 0;
            int above4counter = 0;
            int above3counter = 0;
            int failCounter = 0;
            double gradesSum = 0;

            for (int i = 1; i <= studentsNumber; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradesSum += grade;
                if (grade >= 5)
                {
                    topCounter++;
                }
                else if (grade >= 4)
                {
                    above4counter++;
                }
                else if (grade >= 3)
                {
                    above3counter++;
                }
                else
                {
                    failCounter++;

                }

            }
            Console.WriteLine($"Top students: {(topCounter / (double)studentsNumber * 100):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(above4counter / (double)studentsNumber * 100):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(above3counter / (double)studentsNumber * 100):f2}%");
            Console.WriteLine($"Fail: {(failCounter / (double)studentsNumber * 100):f2}%");
            Console.WriteLine($"Average: {(gradesSum / studentsNumber):f2}");

        }
    }
}
