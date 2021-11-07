namespace MilitaryElite
{
    public abstract class Soldier : ISoldier
    {
        public Soldier(string iD, string firstName, string lastName)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
        }

        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
