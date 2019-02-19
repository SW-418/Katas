using System.Collections.Generic;
using System.Text;

namespace Meeting
{
    public static class MeetingOrganiser
    {
        public static string CreateMeeting(string names)
        {
            var stringBuilder = new StringBuilder();
            var splitNames = names.Split(';');        
            var nameList = new List<Name>();
            
            foreach (var nameString in splitNames)
            {
                var splitName = nameString.Split(':');
                var name = new Name(splitName[0], splitName[1]);
                name.Capitalise();
                nameList.Add(name);
            }

            nameList.Sort();
            nameList.ForEach(x => stringBuilder.Append(x.Format()));
               
            return stringBuilder.ToString();
        }
    }
}
