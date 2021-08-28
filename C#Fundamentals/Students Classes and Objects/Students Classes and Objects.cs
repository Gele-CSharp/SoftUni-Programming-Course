using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentInfo = Console.ReadLine().Split();
            List<Student> students = new List<Student>();

            while (studentInfo[0] != "end")
            {
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                string age = studentInfo[2];
                string hometown = studentInfo[3];

                Student student = new Student(firstName, lastName, age, hometown);
                students.Add(student);

                studentInfo = Console.ReadLine().Split();
            }

            string nameOfCity = Console.ReadLine();

            foreach (Student student in students.Where(x=>x.Hometown == nameOfCity))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, string age, string hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Hometown { get; set; }
    }
}
