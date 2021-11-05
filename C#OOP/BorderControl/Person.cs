namespace BorderControl
{
    public class Person : Citizen, IPerson
    {
        public Person(string iD, string name, string age)
            : base(iD)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; protected set; }


        public string Age { get; protected set; }
    }
}
