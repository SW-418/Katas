using System;
using Xunit;

namespace Meeting
{
    public class Tests
    {
        [Theory]
        [InlineData("Fred:Corwill", "FRED CORWILL")]
        [InlineData("Wilfred:Corwill", "WILFRED CORWILL")]
        [InlineData("Barney:Tornbull", "BARNEY TORNBULL")]
        public void Meeting_GivenASingleName_ShouldCapitaliseNameAndRemoveColon(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.CreateMeeting(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}