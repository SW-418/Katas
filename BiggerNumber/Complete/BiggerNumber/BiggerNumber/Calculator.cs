using System;

namespace BiggerNumber
{
    public static class Calculator
    {
        public static long BiggerNumber(long number)
        {
            var numberLength = Math.Floor(Math.Log10(number) + 1);
            if (numberLength == 1)
            {
                return -1;
            }
            return number;
        }
    }
}
