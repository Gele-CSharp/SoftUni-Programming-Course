namespace MilitaryElite
{
    public class Repair
    {
        public Repair(string partName, string workedHours)
        {
            PartName = partName;
            WorkedHours = workedHours;
        }

        public string PartName { get; set; }

        public string WorkedHours { get; set; }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {WorkedHours}".ToString();
        }
    }
}
