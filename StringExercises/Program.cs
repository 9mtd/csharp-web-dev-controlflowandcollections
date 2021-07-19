using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] words = String.stringMethod().Split(' ');
            string[] sentences = String.stringMethod().Split('.');

            Console.WriteLine(string.Join(",\n", words));
            Console.WriteLine(string.Join(",\n", sentences));

        }        
}
}
