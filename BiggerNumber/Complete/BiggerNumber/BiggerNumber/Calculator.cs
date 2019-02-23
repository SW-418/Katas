using System;
using System.Collections.Generic;
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

            for (var i = 1; i < numberString.Length; i++)
            {
                if (numberString[i - 1] > numberString[i])
                {
                    return -1;
                }
            }
            
            return number;
        }
    }
}
