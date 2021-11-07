namespace MilitaryElite
{
    public class Mission
    {
        public Mission(string codeName, MissionState missionState)
        {
            CodeName = codeName;
            MissionState = missionState;
        }

        public string CodeName { get; set; }

        public MissionState MissionState { get; set; }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {MissionState}";
        }
    }
}
