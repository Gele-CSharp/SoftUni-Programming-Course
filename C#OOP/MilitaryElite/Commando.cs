using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Commando : Soldier, ICommando
    {
        public Commando(string iD, string firstName, string lastName, List<Mission> missions, decimal salary)
            : base(iD, firstName, lastName)
        {
            Missions = new List<Mission>(missions);
            Salary = salary;
        }

        public Corps Corps { get; set; }


        public List<Mission> Missions { get; set; }


        public decimal Salary { get; set; }


        public void CompleteMission(string mission)
        {
            Mission missionToComplete = Missions.FirstOrDefault(m => m.CodeName == mission);

            if (missionToComplete != null)
            {
                missionToComplete.MissionState = MissionState.Finished;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");

            foreach (var mission in Missions)
            {
                sb.AppendLine($"  {mission.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}
