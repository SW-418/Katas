using System;
using Xunit;

namespace BiggerNumber
{
    public class Tests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void BiggerNumber_ReturnsMinus1_WhenSingleDigit(long number)
        {
            var result = Calculator.BiggerNumber(number);
            Assert.Equal(-1, result);
        }
    }
}
