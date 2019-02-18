using System;
using Xunit;

namespace IsPrimeNumber
{
    public class Tests
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(4, false)]
        [InlineData(6, false)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(12, false)]
        [InlineData(14, false)]
        [InlineData(15, false)]
        [InlineData(16, false)]
        public void IsPrime_ShouldReturnFalseIfNotPrime(int n, bool expectedValue)
        {
            var actualResult = PrimeCalculator.IsPrimeNumber(n);
            Assert.Equal(expectedValue, actualResult);
        }
        
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(7, true)]
        [InlineData(11, true)]
        [InlineData(13, true)]
        [InlineData(17, true)]
        [InlineData(19, true)]
        [InlineData(23, true)]
        [InlineData(29, true)]
        public void IsPrime_ShouldReturnTrueIfPrime(int n, bool expectedValue)
        {
            var actualResult = PrimeCalculator.IsPrimeNumber(n);
            Assert.Equal(expectedValue, actualResult);
        }
    }
}
