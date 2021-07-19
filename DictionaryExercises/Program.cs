using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> names = new Dictionary<string, double>();
            string newName;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Name: ");
                string input = Console.ReadLine();
                newName = input;

                if (!Equals(newName, ""))
                {
                    Console.WriteLine("ID Number: ");
                    input = Console.ReadLine();
                    double newId = int.Parse(input);
                    names.Add(newName, newId);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newName, ""));

            // Print class roster
            Console.WriteLine("\nName List:");
            double sum = 0.0;

            foreach (KeyValuePair<string, double> name in names)
            {
                Console.WriteLine(name.Key + " (" + name.Value + ")");
                sum += name.Value;
            }

        }
    }
    }

