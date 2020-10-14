using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentationCommand = Console.ReadLine();
            double notesCount = 0;
            int notesCounter = 0;
            double totalNotesCount = 0;
            int totalNotesCounter = 0;

            while (presentationCommand != "Finish")
            {
                notesCount = 0;
                notesCounter = 0;
                double notes = double.Parse(Console.ReadLine());
                for (int i = 0; i <= jury; i++)
                {
                    notesCount += notes;
                    notesCounter++;
                    if (notesCounter == jury)
                    {
                        Console.WriteLine($"{presentationCommand} - {notesCount / (double)notesCounter:f2}.");
                        break;
                    }
                    notes = double.Parse(Console.ReadLine());
                }
                totalNotesCount += notesCount;
                totalNotesCounter += notesCounter;
                presentationCommand = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalNotesCount / (double)totalNotesCounter:f2}.");
        }
    }
}
