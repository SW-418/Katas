namespace IsPrimeNumber
{
    public static class PrimeCalculator
    {
        public static bool IsPrimeNumber(int number)
        {
            var divisibilityCount = 0;
            
            for (var i = number; i > 0 && divisibilityCount <= 2; i--)
            {
                if (number % i == 0)
                {
                    divisibilityCount++;
                }
            }
            return divisibilityCount == 2;
        }
    }
}
