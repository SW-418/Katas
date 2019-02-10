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
            var lowercaseLetter = true;
            foreach (var letter in message)
            {
                lowercaseLetter = true;
                var index = LowerCaseLetters.IndexOf(letter.ToString());
                if (index == -1)
                {
                    lowercaseLetter = false;
                    index = UpperCaseLetters.IndexOf(letter.ToString());
                }
                var nextIndex = index + 13;
                if (nextIndex >= 26)
                {
                    nextIndex = nextIndex - 26;
                }

                if (lowercaseLetter)
                {
                    cipherText += LowerCaseLetters[nextIndex];
                }
                else
                {
                    cipherText += UpperCaseLetters[nextIndex];
                }
            }

            return cipherText;
        }
    }
}