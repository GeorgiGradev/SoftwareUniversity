using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badNotes = int.Parse(Console.ReadLine());
            string taskName = Console.ReadLine();
            int notes = 0; 

            int countTasks = 0;
            int countBadNotes = 0;
            int score = 0;
            double averageScore = 0;
            string lastTaskName = "";

            while (taskName != "Enough")
            {
                notes = int.Parse(Console.ReadLine());
                countTasks++;
                score += notes;
                if (notes <= 4)
                {
                    countBadNotes++;
                    if (countBadNotes == badNotes)
                    {
                        break;
                    }
                }
                lastTaskName = taskName;
                taskName = Console.ReadLine();      
            }
            averageScore = score / (1.0 * countTasks);
            if (countBadNotes == badNotes)
            {
                Console.WriteLine($"You need a break, {countBadNotes} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {countTasks}");
                Console.WriteLine($"Last problem: {lastTaskName}");
            }

        }
    }
}

