using System.Collections.Generic;

namespace Rot13
{
    public class Rot13
    {
        private static readonly List<string> LowerCaseLetters = new List<string>{ "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" };
        private static readonly List<string> UpperCaseLetters = new List<string>{ "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };
        
        public static string ConvertMessage(string message)
        {
            var cipherText = "";
            foreach (var letter in message)
            {
                var isLowerCase = true;
                var letterString = letter.ToString();
                if (IsNonAlpha(letterString))
                {
                    cipherText += letterString;
                }
                else
                {
                    var index = LowerCaseLetters.IndexOf(letterString);
                    if (index == -1)
                    {
                        index = UpperCaseLetters.IndexOf(letterString);
                        isLowerCase = false;
                    }

                    var nextIndex = CalculateNextIndex(index);

                    if (isLowerCase)
                    {
                        cipherText += LowerCaseLetters[nextIndex];
                    }
                    else
                    {
                        cipherText += UpperCaseLetters[nextIndex];
                    }    
                }           
            }
            return cipherText;
        }

        private static bool IsNonAlpha(string character)
        {
            var lowerIndex = LowerCaseLetters.IndexOf(character);
            var upperIndex = UpperCaseLetters.IndexOf(character);
            return lowerIndex == -1 && upperIndex == -1;
        }

        private static int CalculateNextIndex(int index)
        {
            var nextIndex = index + 13;
            if (nextIndex >= 26)
            {
                nextIndex = nextIndex - 26;
            }

            return nextIndex;
        }
    }
}