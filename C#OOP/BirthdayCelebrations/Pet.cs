namespace BorderControl
{
    public class Pet : IPet, IBirthDate
    {
        public Pet(string name, string birtDate)
        {
            Name = name;
            BirtDate = birtDate;
        }

        public string Name { get; protected set; }

        public string BirtDate { get; protected set; }
    }
}
