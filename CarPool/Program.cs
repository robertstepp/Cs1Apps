// Robert Stepp
// TINFO 200
// Cs1 Apps / CarPool
///////////////////////////////
//Change History
// Date     Developer   Description
//01132020  rstepp      File creation and initial implementation of the application
//
// References Used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPool
{
    class Program
    {
        // Variable for the number of miles driver per day by the user. (#.#)
        private static double milesDriven; // Per day

        // Variable for the cost of fuel per gallon. ($#.##)
        private static double costFuel; // Cents

        // Variable for the miles per gallon the user gets. (#.#)
        private static double avgMPG; // Miles

        // Variable for the amount the user pays per day for parking fees. ($#.##)
        private static double parkingFees; // Cents

        // Variable for the amount the user pays per day for tolls ($#.##)
        private static double tollsDay; // Cents

        // Display method to provide user information on the program.
        private static void UserInterface()
        {
            // User Interface
            // Describes use of the program and input information.
            Console.WriteLine(@"
***********************************************
** Welcome to the Carpool Savings Calculator **
***********************************************
This program will tell you the amount spent 
everyday to commute to and from work/school.


");
        }

        // Main method that calls other single use methods
        static void Main(string[] args)
        {
        }
    }
}
