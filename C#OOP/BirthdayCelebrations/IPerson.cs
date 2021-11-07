namespace BorderControl
{
    public interface IPerson : IBirthDate
    {
        public string Name { get; }

        public string Age { get; }
    }
}
