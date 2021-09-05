using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split();
                string student = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (students.ContainsKey(student) == false)
                {
                    students.Add(student, new List<decimal>());
                }

                students[student].Add(grade);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x=>x.ToString("f2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
