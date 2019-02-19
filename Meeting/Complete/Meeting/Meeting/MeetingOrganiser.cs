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
                stringBuilder.Append(name.Format());
            }
               
            return stringBuilder.ToString();
        }
    }
}
