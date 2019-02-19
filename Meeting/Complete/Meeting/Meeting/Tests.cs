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
        public void CreateMeeting_GivenASingleName_ShouldCapitaliseNameAndRemoveColon(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.CreateMeeting(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [InlineData("Fred:Corwill", "CORWILL FRED")]
        [InlineData("Wilfred:Corwill", "CORWILL WILFRED")]
        [InlineData("Barney:Tornbull", "TORNBULL BARNEY")]
        [InlineData("Betty:Tornbull", "TORNBULL BETTY")]
        [InlineData("Bjorn:Tornbull", "TORNBULL BJORN")]
        [InlineData("Rachel:Corwill", "CORWILL RACHEL")]
        [InlineData("Alfred:Corwill", "CORWILL ALFRED")]
        public void CreateMeeting_GivenASingleName_ShouldSwapSurnameAndName(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.CreateMeeting(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
        
        
    }
}
