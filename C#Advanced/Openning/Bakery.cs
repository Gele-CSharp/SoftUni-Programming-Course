using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> employees;

        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            employees = new List<Employee>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count { get; private set; }

        public void Add(Employee employee)
        {
            if (employees.Count < Capacity)
            {
                employees.Add(employee);
                Count++;
            }
        }

        public bool Remove(string name)
        {
            bool isRemoved = false;

            if (employees.Select(e=> e.Name).Contains(name))
            {
                Employee employeeToRemove = employees.Where(e => e.Name == name).FirstOrDefault();
                employees.Remove(employeeToRemove);
                Count--;
                isRemoved = true;
            }

            return isRemoved;
        }

        public Employee GetOldestEmployee()
        {
            Employee oldestEmployee = employees.OrderByDescending(e => e.Age).FirstOrDefault();
            return oldestEmployee;
        }

        public Employee GetEmployee(string name)
        {
            if (employees.Select(e => e.Name).Contains(name))
            {
                Employee employee = employees.Where(e => e.Name == name).FirstOrDefault();
                return employee;
            }

            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Employees working at Bakery {Name}:");

            foreach (var employee in employees)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString();
        }
    }
}
