using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : Soldier, IEngineer
    {
        public Engineer(string iD, string firstName, string lastName, Corps corps, decimal salary, List<Repair> repairs)
            : base(iD, firstName, lastName)
        {
            Corps = corps;
            Salary = salary;
            Repairs = new List<Repair>(repairs);
        }

        public List<Repair> Repairs { get; set; }

        public Corps Corps { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");

            foreach (var repair in Repairs)
            {
                sb.AppendLine($"  {repair.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}
