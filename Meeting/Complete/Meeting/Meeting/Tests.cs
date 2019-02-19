using System;
using Xunit;

namespace Meeting
{
    public class Tests
    {   
        [Theory]
        [InlineData("Fred Corwill", "FRED CORWILL")]
        [InlineData("Wilfred Corwill", "WILFRED CORWILL")]
        [InlineData("Barney Tornbull", "BARNEY TORNBULL")]
        [InlineData("Betty Tornbull", "BETTY TORNBULL")]
        [InlineData("Bjorn Tornbull", "BJORN TORNBULL")]
        [InlineData("Rachel Corwill", "RACHEL CORWILL")]
        [InlineData("Alfred Corwill", "ALFRED CORWILL")]
        public void CapitaliseName_GivenASingleName_ShouldCapitaliseName(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.CapitaliseName(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
        
        
        [Theory]
        [InlineData("FRED CORWILL", "CORWILL FRED")]
        [InlineData("WILFRED CORWILL", "CORWILL WILFRED")]
        [InlineData("BARNEY TORNBULL", "TORNBULL BARNEY")]
        [InlineData("BETTY TORNBULL", "TORNBULL BETTY")]
        [InlineData("BJORN TORNBULL", "TORNBULL BJORN")]
        [InlineData("RACHEL CORWILL", "CORWILL RACHEL")]
        [InlineData("ALFRED CORWILL", "CORWILL ALFRED")]
        public void ReverseNames_GivenASingleName_ShouldSwapSurnameAndName(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.ReverseNames(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
        
        [Theory]
        [InlineData("Fred:Corwill", "(CORWILL, FRED)")]
        [InlineData("Wilfred:Corwill", "(CORWILL, WILFRED)")]
        [InlineData("Barney:Tornbull", "(TORNBULL, BARNEY)")]
        [InlineData("Betty:Tornbull", "(TORNBULL, BETTY)")]
        [InlineData("Bjorn:Tornbull", "(TORNBULL, BJORN)")]
        [InlineData("Rachel:Corwill", "(CORWILL, RACHEL)")]
        [InlineData("Alfred:Corwill", "(CORWILL, ALFRED)")]
        public void CreateMeeting_GivenASingleName_ShouldReturnFormattedCapitalisedName(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.CreateMeeting(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
        
        
    }
}
