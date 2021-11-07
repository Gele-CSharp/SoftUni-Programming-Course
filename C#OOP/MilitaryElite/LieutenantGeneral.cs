using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string iD, string firstName, string lastName, decimal salary, List<ISoldier> privates)
            : base(iD, firstName, lastName, salary)
        {
            Privates = new List<ISoldier>(privates);
        }

        public ICollection<ISoldier> Privates { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:f2}");
            sb.AppendLine("Privates:");

            foreach (var @private in Privates)
            {
                sb.AppendLine($"  {@private.ToString()}");
            }

            return sb.ToString();
        }
    }
}
