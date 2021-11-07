namespace BorderControl
{
    public class Person : Citizen, IPerson
    {
        public Person(string iD, string name, string age, string birtDate)
            : base(iD)
        {
            Name = name;
            Age = age;
            BirtDate = birtDate;
        }

        public string Name { get; protected set; }


        public string Age { get; protected set; }


        public string BirtDate { get; protected set; }
    }
}
