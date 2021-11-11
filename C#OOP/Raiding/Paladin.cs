namespace Raiding
{
    public class Paladin : Druid
    {
        public Paladin(string name) 
            : base(name)
        {
        }

        public override int Power { get; protected set; } = 100;
    }
}
