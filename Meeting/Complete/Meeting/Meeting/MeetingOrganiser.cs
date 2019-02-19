using System.Text;

namespace Meeting
{
    public static class MeetingOrganiser
    {
        public static string CreateMeeting(string names)
        {
            var stringBuilder = new StringBuilder();
            var splitNames = names.Split(';');
            foreach (var nameString in splitNames)
            {
                var splitName = nameString.Split(':');
                var name = new Name(splitName[0], splitName[1]);
                name.Capitalise();
                        
                stringBuilder.Append("(");
                stringBuilder.Append(name.Surname);
                stringBuilder.Append(", ");
                stringBuilder.Append(name.FirstName);
                stringBuilder.Append(")");
            }
               
            return stringBuilder.ToString();
        }
    }

    public class Name
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
    }
}
