using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double avarageGrade = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int totalCount = 0;
            double grade1 = 0;
            double grade2 = 0;
            double grade3 = 0;
            double grade4 = 0;



            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 2.00 && grade < 3.00)
                {
                    grade1 = grade1 + grade;
                    count1 += 1; 
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    grade2 = grade2 + grade;
                    count2 += 1;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    grade3 = grade3 + grade;
                    count3 += 1;
                }
                else if (grade >= 5.00 && grade <= 6.00)
                {
                    grade4 = grade4 + grade;
                    count4 += 1;
                }
            }
            totalCount = count1 + count2 + count3 + count4;
            avarageGrade = (grade1 + grade2 + grade3 + grade4)/ (students) * 1.0;
            double st1 = count1 / (totalCount * 1.0) * 100;
            double st2 = count2 / (totalCount * 1.0) * 100;
            double st3 = count3 / (totalCount * 1.0) * 100;
            double st4 = count4 / (totalCount * 1.0) * 100;

            Console.WriteLine($"Top students: {st4:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {st3:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {st2:F2}%");
            Console.WriteLine($"Fail: {st1:F2}%");
            Console.WriteLine($"Average: {avarageGrade:F2}");
        }
    }
}
