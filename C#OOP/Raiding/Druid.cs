namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) 
            : base(name)
        {
        }

        public override int Power { get; protected set; } = 80;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}".ToString();
        }
    }
}
