using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                List<string> task = command.Split(':').ToList();

                string modifyCommand = task[0];
                string lessonTitle = task[1];

                if (modifyCommand == "Add")
                {
                    if (input.Contains(lessonTitle) == false)
                    {
                        input.Add(lessonTitle);
                    }
                }
                else if (modifyCommand == "Insert")
                {
                    if (input.Contains(lessonTitle) == false)
                    {
                        input.Insert(int.Parse(task[2]), lessonTitle);
                    }
                }
                else if (modifyCommand == "Remove")
                {
                    if (input.Contains(lessonTitle) == true)
                    {
                        input.Remove(lessonTitle);
                        if (input.Contains($"Exercise:{lessonTitle}"))
                        {
                            input.Remove($"Exercise:{lessonTitle}");
                        }
                    }
                }
                else if (modifyCommand == "Swap")
                {
                    string secondLessonTitle = task[2];
                    if (input.Contains(lessonTitle) && input.Contains(secondLessonTitle))
                    {
                        int indexOfLessonTitle = input.IndexOf(lessonTitle);
                        int indexOfSecondLessonTitle = input.IndexOf(secondLessonTitle);

                        string temp = lessonTitle;
                        input[indexOfLessonTitle] = input[indexOfSecondLessonTitle];
                        input[indexOfSecondLessonTitle] = temp;


                        if (input.Contains($"{lessonTitle}-Exercise"))
                        {
                            input.Remove($"{lessonTitle}-Exercise");
                            input.Insert(input.IndexOf(lessonTitle)+1, $"{lessonTitle}-Exercise");
                        }
                        else if (input.Contains($"{secondLessonTitle}-Exercise"))
                        {
                            input.Remove($"{secondLessonTitle}-Exercise");
                            input.Insert(input.IndexOf(secondLessonTitle) + 1, $"{secondLessonTitle}-Exercise");
                        }
                    }
                }
                else if (modifyCommand == "Exercise")
                {
                    if (input.Contains(lessonTitle) && input.Contains($"{lessonTitle}-Exercise") == false)
                    {
                        input.Insert(input.IndexOf(lessonTitle) + 1, $"{lessonTitle}-Exercise");
                    }
                    else if (input.Contains(lessonTitle) == false)
                    {
                        input.Add(lessonTitle);
                        input.Add($"{lessonTitle}-Exercise");
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
    }
}
