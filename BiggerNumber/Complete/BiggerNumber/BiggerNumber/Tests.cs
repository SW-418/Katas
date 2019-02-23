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
        
        [Theory]
        [InlineData(111)]
        [InlineData(22)]
        [InlineData(33333)]
        [InlineData(44)]
        [InlineData(55555)]
        [InlineData(666)]
        [InlineData(777)]
        [InlineData(888)]
        [InlineData(999)]
        public void BiggerNumber_ReturnsMinus1_WhenNumberIsRecurringDigits(long number)
        {
            var result = Calculator.BiggerNumber(number);
            Assert.Equal(-1, result);
        }
    }
}
