using System;
using Xunit;

namespace Meeting
{
    public class Tests
    {   
        [Theory]
        [InlineData("Fred", "Corwill", "FRED","CORWILL")]
        [InlineData("Wilfred","Corwill", "WILFRED","CORWILL")]
        [InlineData("Barney","Tornbull", "BARNEY","TORNBULL")]
        [InlineData("Betty","Tornbull", "BETTY","TORNBULL")]
        [InlineData("Bjorn","Tornbull", "BJORN","TORNBULL")]
        [InlineData("Rachel","Corwill", "RACHEL","CORWILL")]
        [InlineData("Alfred","Corwill", "ALFRED","CORWILL")]
        public void Capitalise_GivenANonCapitalisedName_ShouldCapitaliseName(string firstName, string secondName, 
            string capitalisedFirstName, string capitalisedSurname)
        {
            var name = new Name(firstName, secondName);
            name.Capitalise();
            Assert.Equal(capitalisedFirstName, name.FirstName);
            Assert.Equal(capitalisedSurname, name.Surname);
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
        
        [Theory]
        [InlineData("Fred:Corwill;Wilfred:Corwill", "(CORWILL, FRED)(CORWILL, WILFRED)")]
        [InlineData("Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull", "(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)")]
        public void CreateMeeting_GivenListOfNames_ShouldReturnFormattedCapitalisedNames(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.CreateMeeting(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
        
        [Theory]
        [InlineData("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill"
            , "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        public void CreateMeeting_GivenListOfNames_ShouldReturnNamesInAlphabeticalOrder(string initialName, string expectedResult)
        {
            var actualResult = MeetingOrganiser.CreateMeeting(initialName);
            Assert.Equal(expectedResult, actualResult);
        }
        
        
        
        
    }
}
