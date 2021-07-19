using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    public class LetterMethod
    {
        public static void letterMatching(int wordLength)
        {

            List<string> newList = new List<string> { "a", "ab", "abc", "abcd", "abcdf" };
            foreach (var word in newList)
            {
                if (word.Length == wordLength)
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
