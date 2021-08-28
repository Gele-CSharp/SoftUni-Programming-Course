using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName) == false)
                {
                    students.Add(studentName, new List<double> { grade });
                }
                else
                {
                    students[studentName].Add(grade);
                }
            }

            foreach (var student in students.Where(s=>s.Value.Sum() / s.Value.Count >= 4.50)
                                            .OrderByDescending(s=>s.Value.Sum() / s.Value.Count))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Sum() / student.Value.Count:f2}");
            }
        }
    }
}
