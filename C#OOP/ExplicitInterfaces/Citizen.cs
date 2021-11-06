namespace ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
    {
        private string name;
        private int age;
        private string country;

        public Citizen(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name
        {
            get => name;

            private set
            {
                name = value;
            }
        }

        public int Age
        {
            get => age;

            private set
            {
                age = value;
            }
        }

        public string Country
        {
            get => country;

            private set
            {
                country = value;
            }
        }

        string IPerson.GetName()
        {
            return Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}".ToString();
        }
    }
}
