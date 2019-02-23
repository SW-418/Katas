using System;
using System.Linq;

namespace BiggerNumber
{
    public static class Calculator
    {
        public static long BiggerNumber(long number)
        {
            var numberString = number.ToString();
            if (numberString.Length == 1)
            {
                return -1;
            }
           
            var firstNumber = numberString[0];
            var recurringNumbers = numberString.Count(x => x == firstNumber);

            if (recurringNumbers == numberString.Length)
            {
                return -1;
            }
            return number;
        }
    }
}
