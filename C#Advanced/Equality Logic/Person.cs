using System;

namespace Equality_Logic
{
    public class Person: IComparable<Person>
    {
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if(result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }

        public override int GetHashCode() => Name.GetHashCode() ^ Age.GetHashCode();

        public override bool Equals(object obj)
        {
            var other = obj as Person;

            if (other == null)
            {
                return false;
            }

            return Name == other.Name && Age == other.Age;
        }
    }
}
