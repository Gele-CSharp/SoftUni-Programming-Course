namespace Raiding
{
    public class Rogue : Warrior
    {
        private const int CurrentPower = 80;

        public Rogue(string name) 
            : base(name)
        {
        }

        public override int Power { get; protected set; } = 80;
    }
}
