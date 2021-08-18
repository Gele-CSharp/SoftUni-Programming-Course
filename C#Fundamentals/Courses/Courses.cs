using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string[] courseInfo = Console.ReadLine().Split(':');

            while (courseInfo[0].Trim() != "end")
            {
                string courseName = courseInfo[0].Trim();
                string studentName = courseInfo[1].Trim();

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string> { studentName });
                }

                courseInfo = Console.ReadLine().Split(':');
            }

            foreach (var course in courses.OrderByDescending(c=>c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(s=>s))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
