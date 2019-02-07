using Xunit;

namespace TwoWordNameAbbreviation
{
    public class TwoWordNameAbbreviationTests
    {
        [Theory]
        [InlineData("Sam Harris", "S.H")]
        [InlineData("Patrick Feeney", "P.F")]
        [InlineData("Sam Wells", "S.W")]
        [InlineData("Yeety Yeeterson", "Y.Y")]
        public void TwoWordName_ShouldReturnAbbreviationSeparatedByPeriod(string name, string expectedString)
        {
            var actualString = CalculateAbbreviation(name);

            Assert.Equal(expectedString, actualString);
        }

        static string CalculateAbbreviation(string name)
        {
            var splitName = name.Split(' ');
            return splitName[0][0] + "." + splitName[1][0];
        }
    }
}
