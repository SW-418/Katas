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


            var numberString = number.ToString();
            var firstNumber = numberString[0];
            var recurringNumbers = 0;
            for (var i = 1; i < numberLength; i++)
            {
                if (firstNumber == numberString[i])
                {
                    recurringNumbers++;
                }
            }

            if (recurringNumbers == numberLength - 1)
            {
                return -1;
            }
            return number;
        }
    }
}
