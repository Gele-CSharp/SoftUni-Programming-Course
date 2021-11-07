using System.Collections.Generic;

namespace MilitaryElite
{
    interface IEngineer : ISpecialisedSoldier
    {
        public List<Repair> Repairs { get; set; }
    }
}
