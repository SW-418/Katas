using System;
namespace GreenValley
{
    public class Valley
    {
        public static int[] MakeValley(int[] arr){
            var valleyWithWings = new int[arr.Length];
            var firstIndex = 0;
            var secondIndex = 1;
            
            for (var i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0){
                    valleyWithWings[firstIndex] = arr[i];
                    firstIndex++;
                }
                else{
                    valleyWithWings[arr.Length - secondIndex] = arr[i];
                    secondIndex++;
                }
            }
            return valleyWithWings;
        }
    }
}
