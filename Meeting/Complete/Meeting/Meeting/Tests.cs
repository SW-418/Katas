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
        [InlineData("Betty:Tornbull", "BETTY TORNBULL")]
        [InlineData("Bjorn:Tornbull", "BJORN TORNBULL")]
        [InlineData("Rachel:Corwill", "RACHEL CORWILL")]
        [InlineData("Alfred:Corwill", "ALFRED CORWILL")]
        public void Meeting_GivenASingleName_ShouldCapitaliseNameAndRemoveColon(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.CreateMeeting(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
