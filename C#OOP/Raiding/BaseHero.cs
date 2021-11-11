namespace Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }

        public virtual int Power { get; protected set; }

        public virtual string CastAbility()
        {
            return string.Empty;
        }
    }
}
