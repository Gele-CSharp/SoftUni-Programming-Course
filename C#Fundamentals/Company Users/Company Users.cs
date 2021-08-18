using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                string companyName = input[0];
                string employeeID = input[1];

                if (companies.ContainsKey(companyName) == false)
                {
                    companies.Add(companyName, new List<string> { employeeID });
                }
                else
                {
                    if (companies[companyName].Contains(employeeID) == false)
                    {
                        companies[companyName].Add(employeeID);
                    }
                }

                input = Console.ReadLine().Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var company in companies.OrderBy(c=>c.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var employeeID in company.Value)
                {
                    Console.WriteLine($"--{ employeeID}");
                }
            }
        }
    }
}
