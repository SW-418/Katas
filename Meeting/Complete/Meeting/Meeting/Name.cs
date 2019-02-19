using System;
using System.Text;

namespace Meeting
{
    public class Name : IComparable<Name>
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        
        public Name(string firstName, string surname)
        {
            FirstName = firstName;
            Surname = surname;
        }

        public void Capitalise()
        {
            FirstName = FirstName.ToUpper();
            Surname = Surname.ToUpper();
        }

        public string Format()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("(");
            stringBuilder.Append(this.Surname);
            stringBuilder.Append(", ");
            stringBuilder.Append(this.FirstName);
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }

        public int CompareTo(Name name)
        {
            return this.Surname.Equals(name.Surname) ? 
                FirstName.CompareTo(name.FirstName) : Surname.CompareTo(name.Surname);
        }
    }
}