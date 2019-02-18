namespace IsPrimeNumber
{
    public static class PrimeCalculator
    {
        public static bool IsPrimeNumber(int number)
        {
            return number > 1 && number % 1 == 0 && number % number == 0;
        }
    }
}
