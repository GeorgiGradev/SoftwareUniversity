using System;

namespace _09._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {


            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrHour = int.Parse(Console.ReadLine());
            int arrMin = int.Parse(Console.ReadLine());

            int examTimeMin = examMin + (examHour * 60);
            int arrTimeMin = arrMin + (arrHour * 60);
            int differenceMin = Math.Abs(examTimeMin - arrTimeMin);
            int hour = differenceMin / 60;
            int minutes = differenceMin % 60;


            if ((examTimeMin - arrTimeMin) == 0)
            {
                Console.WriteLine("On time");
            }
            else if ((examTimeMin - arrTimeMin) <= 30 && (examTimeMin - arrTimeMin) > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{differenceMin} minutes before the start");
            }


            else if (arrTimeMin - examTimeMin < 60 && arrTimeMin - examTimeMin > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{differenceMin} minutes after the start");
            }
            else if (arrTimeMin - examTimeMin >= 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
            }


            else if (examTimeMin - arrTimeMin < 60 && examTimeMin - arrTimeMin >0)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{differenceMin} minutes before the start");
            }
            else if ((examTimeMin - arrTimeMin) >= 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
            }
        }
    }
}
