using System;
using System.Collections.Generic;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrone(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            var reversed = new string(arr);

            if (reversed == word)
            {
                return true;
            }
            return false;
        }
    }
}
