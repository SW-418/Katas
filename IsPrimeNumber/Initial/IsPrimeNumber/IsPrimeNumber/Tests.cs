using System;
using Xunit;

namespace IsPrimeNumber
{
    public class Tests
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, false)]
        public void IsPrime_ShouldReturnFalseIfNotPrime(int n, bool expectedValue)
        {
            var actualResult = PrimeCalculator.IsPrimeNumber(n);
            Assert.Equal(expectedValue, actualResult);
        }
        
//        [Theory]
//        [InlineData(2, true)]
//        public void IsPrime_ShouldReturnTrueIfPrime(int n, bool expectedValue)
//        {
//            var actualResult = PrimeCalculator.IsPrimeNumber(n);
//            Assert.Equal(expectedValue, actualResult);
//        }
    }
}
