namespace BorderControl
{
    public abstract class Citizen
    {
        public Citizen(string iD)
        {
            ID = iD;
        }

        public string ID { get; protected set; }
    }
}
