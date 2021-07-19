using System;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = EvenMethod.sumofEvens(integers);
            Console.WriteLine("The sum of even integers is: " + result);


            Console.WriteLine("Enter the word length for search: ");
            string input = Console.ReadLine();
            var isParsed = int.TryParse(input, out int wordLength);
            if (isParsed)
            {
                LetterMethod.letterMatching(wordLength);
            }
        }
    }
}
