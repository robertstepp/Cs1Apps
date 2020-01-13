// Robert Stepp
// TINFO 200
// Cs1 Apps / DigitParser
///////////////////////////////
//Change History
// Date     Developer   Description
//01132020  rstepp      File creation and initial implementation of the application
//
// References Used
// Lasse Espeholt.(2018, April 5). Integer to Integer Array C#. 
//     Retrieved from https://stackoverflow.com/questions/4580261/integer-to-integer-array-c-sharp.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitParser
{
    // Takes a five digit input from the user and outputs each digit separated by three spaces each.
    class Program
    {
        // Variable to store number input.
        private static int numberGiven;

        // Display method to provide user information on the program.
        private static void UserInterface()
        {
            // User Interface
            // Describes use of the program and input information.
            Console.WriteLine(@"
*************************************
**** Welcome to the digit parser ****
*************************************
This program is designed to take a five
digit input from you and output it with
three spaces between each digit. 

Please watch carefully, the program only 
accepts whole number inputs.
");
        }

        // Get method to receive information from the user.
        private static void UserInput()
        {
            // Prompt user for whole number input.
            Console.Write("Please enter a five digit number (eg 25404, 98402, etc): ");

            // Store the input.
            numberGiven = int.Parse(Console.ReadLine());
        }

        // Take the numer that was given and put into an Integer array that is passed to the output.
        // This section was derived from Lasse Espenholts answer on StackOverflow.
        private static int[] ParseInput()
        {
            int localNumberGiven = numberGiven;
            int[] parsedNumbers = new int[numberGiven.ToString().Length];
            for (int position = 0; position < numberGiven.ToString().Length; position += 1)
            {
                parsedNumbers[position] = localNumberGiven % 10;
                localNumberGiven /= 10;
            }
            return parsedNumbers;
        }

        // Output the array to the screen with correct formatting.
        private static void ScreenOutput(int[] numbers)
        {
            Console.WriteLine($"Your number {numberGiven} is parsed as: ");
            int numberPosition = numbers.Length;
            while (numberPosition > 0)
            {
                Console.Write($"{numbers[numberPosition - 1]}   " );
                numberPosition -= 1;
            }
            Console.WriteLine("");
        }

        // Main method that calls other single use methods
        static void Main(string[] args)
        {
            UserInterface();
            UserInput();
            ScreenOutput(ParseInput());
        }
    }
}
