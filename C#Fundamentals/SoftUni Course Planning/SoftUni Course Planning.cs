using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

            string[] command = Console.ReadLine().Split(':');

            while (command[0] != "course start")
            {
                string lesson = command[1];

                if (command[0] == "Add")
                {
                    if (schedule.Contains(lesson) == false)
                    {
                        schedule.Add(lesson);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);

                    if (schedule.Contains(lesson) == false)
                    {
                        schedule.Insert(index, lesson);
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (schedule.Contains(lesson))
                    {
                        schedule.Remove(lesson);
                    }
                }
                else if (command[0] == "Swap")
                {
                    string lessonToSwap = command[2];

                    if (schedule.Contains(lesson) && schedule.Contains(lessonToSwap))
                    {
                        int indexOfLesson = schedule.IndexOf(lesson);
                        int indexOfLessonToSwap = schedule.IndexOf(lessonToSwap);
                        schedule.RemoveAt(indexOfLesson);
                        schedule.Insert(indexOfLesson, lessonToSwap);
                        schedule.RemoveAt(indexOfLessonToSwap);
                        schedule.Insert(indexOfLessonToSwap, lesson);

                        if (schedule.Contains(($"{lesson}-Exercise")))
                        {
                            schedule.RemoveAt(indexOfLesson + 1);
                            schedule.Insert(indexOfLessonToSwap + 1, ($"{lesson}-Exercise"));
                        }

                        if (schedule.Contains(($"{lessonToSwap}-Exercise")))
                        {
                            schedule.RemoveAt(indexOfLessonToSwap + 1);
                            schedule.Insert(indexOfLesson + 1, ($"{lessonToSwap}-Exercise"));
                        }
                    }
                }
                else if (command[0] == "Exercise")
                {
                    if (schedule.Contains(lesson) && schedule.Contains(($"{lesson}-Exercise")) == false)
                    {
                        int indexOfExercise = schedule.IndexOf(lesson) + 1;
                        schedule.Insert(indexOfExercise, ($"{lesson}-Exercise"));
                    }
                    else if (schedule.Contains(lesson) == false)
                    {
                        schedule.Add(lesson);
                        schedule.Add(($"{lesson}-Exercise"));
                    }
                }

                command = Console.ReadLine().Split(':');
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
