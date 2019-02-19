using System;
using System.Text;

namespace Meeting
{
    public static class MeetingOrganiser
    {
        public static string CreateMeeting(string names)
        {
            var stringbuilder = new StringBuilder();
            stringbuilder.Append("(");
            var splitNames = names.Split(':');
            var newName = splitNames[0] + " " + splitNames[1];

            var capitalisedName = CapitaliseName(newName);
            var reversedName = ReverseNames(capitalisedName);

            var formattedName = reversedName.Replace(" ", ", ");

            stringbuilder.Append(formattedName);
            stringbuilder.Append(")");
               
            return stringbuilder.ToString();
        }

        public static string CapitaliseName(string name)
        {
            var splitName = name.Split(' ');
            return splitName[0].ToUpper() + " " + splitName[1].ToUpper();
        }

        public static string ReverseNames(string name)
        {
            var splitName = name.Split(' ');
            return splitName[1] + " " + splitName[0];
        }
    }
}
