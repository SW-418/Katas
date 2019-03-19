using System;
using System.Linq;
using System.Text;

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

            var isBiggestNumber = true;
            for (var i = 1; i < numberString.Length && isBiggestNumber; i++)
            {
                if (numberString[i - 1] < numberString[i])
                {
                    isBiggestNumber = false;
                }
            }

            if (isBiggestNumber)
            {
                return -1;
            }

            
            for (var i = numberString.Length - 2; i >= 0; i--)
            {
                var currentNumber = numberString[i + 1];
                if (currentNumber > numberString[i])
                {
                    var newNumberString = numberString.Substring(0, i);
                    var stringBuilder = new StringBuilder(numberString);
                    stringBuilder.Remove(i, 2);
                    stringBuilder.Insert(i, currentNumber+""+numberString[i]);         
                    
                    return Convert.ToInt64(stringBuilder.ToString());
                }
            }   
            return number;
        }
    }
}
