using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    public class EvenMethod
    {
        public static int sumofEvens (int[] integers)
        {
            int result = 0;
                foreach (int i in integers)
                if (i % 2 == 0)
                {
                   result += i;
                }
            return result;
        }
    }
}
