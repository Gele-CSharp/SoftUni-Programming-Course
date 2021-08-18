using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split();

                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string departmentName = employeeInfo[2];

                if (departments.Any(x=>x.DepartmentName == departmentName) == false)
                {
                    Department department = new Department(departmentName);
                    departments.Add(department);
                }

                Employee employee = new Employee(name, salary, departmentName);
                departments.Find(x => x.DepartmentName == departmentName).AddEmployee(name, salary, departmentName);
            }

            Department highestAverageSalaryDepartment = departments.OrderByDescending(x => x.TotalSalary / x.employees.Count).First();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.DepartmentName}");

            foreach (Employee employee in highestAverageSalaryDepartment.employees.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }

    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }

    class Department
    {
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }

        public string DepartmentName { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();
        public double TotalSalary { get; set; }

        public void AddEmployee(string name, double salary, string department)
        {
            this.employees.Add(new Employee(name, salary, department));
            TotalSalary += salary;
        }
    }
}
