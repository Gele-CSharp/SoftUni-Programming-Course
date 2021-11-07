using System.Collections.Generic;

namespace MilitaryElite
{
    interface ICommando : ISpecialisedSoldier
    {
        public List<Mission> Missions { get; set; }

        public void CompleteMission(string mission);
    }
}
