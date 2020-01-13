// Robert Stepp
// TINFO 200
// Cs1 Apps / OddOrEven
///////////////////////////////
//Change History
// Date     Developer   Description
//01132020  rstepp      File creation and initial implementation of the application


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven

    // Takes a whole number input from the user and displays whether the number is odd or even. 
    // Uses remainder of dividing by two to determine output.
{
    class Program
    {
        // Variable to store number input
        private static int numberGiven;


        // Display method to provide user information on the program.
        private static void UserInterface()
        {
            // User Interface
            // Describes use of the program and input information
            Console.WriteLine(@"
****************************************
*** Welcome to the odd or even check ***
****************************************
This program is designed to check an 
input to see if it is odd or even. This 
is useful if you are unsure or want to
add this functionality to a later program.

Please watch carefully, the program only 
accepts whole number inputs.
");
        }

        // Get method to receive information from the user.
        private static void UserInput()
        {
            // Prompt user for whole number input
            Console.Write("Please enter a whole number (eg 25, 40, etc): ");
            
            // Store the input
            numberGiven = int.Parse(Console.ReadLine());
        }

        // Take the user input and determine odd or even
        private static Boolean ComputeOutput()
        {
            // Local variable for result
            bool result;

            // Assign result
            if (numberGiven % 2 == 0)
            {
                result = true; 
            } else
            {
                result = false;
            }

            // Provide result to calling method
            return result;
        }

        // Display result of check to the user.
        private static void ScreenOutput(bool result)
        {
            // Provide output based on boolean value result.
            if (result == true)
            {
                Console.WriteLine($"Your input of {numberGiven} is even.");
            } else
            {
                Console.WriteLine($"Your input of {numberGiven} is odd.");
            }

        }

        // Main method that calls other single use methods
            static void Main(string[] args)
        {
            UserInterface();
            UserInput();
            ScreenOutput(ComputeOutput());

        }
    }
}
