using Xunit;

namespace TwoWordNameAbbreviation
{
    public class TwoWordNameAbbreviationTests
    {
        [Theory]
        [InlineData("Sam Harris")]
        public void TwoWordName_ShouldReturnAbbreviationSeparatedByPeriod(string name)
        {
            var expectedString ="S.H";
            var actualString = CalculateAbbreviation(name);

            Assert.Equal(expectedString, actualString);
        }

        static string CalculateAbbreviation(string name)
        {
            return "blah";
        }
    }
}
