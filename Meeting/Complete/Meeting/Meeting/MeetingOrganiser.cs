namespace Meeting
{
    public static class MeetingOrganiser
    {
        public static string CreateMeeting(string names)
        {
            var splitNames = names.Split(':');
            var newName = splitNames[0].ToUpper() + " " + splitNames[1].ToUpper();
            return newName;
        }
    }
}
