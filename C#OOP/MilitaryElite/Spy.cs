using System;

namespace MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string iD, string firstName, string lastName, int codeNumber)
            : base(iD, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {ID}" + Environment.NewLine + $"Code Number: {CodeNumber}";
        }
    }
}
