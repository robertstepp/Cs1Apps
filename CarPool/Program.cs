// Robert Stepp
// TINFO 200
// Cs1 Apps / CarPool
///////////////////////////////
// Change History
// Date     Developer   Description
// 01132020  rstepp     File creation and initial implementation of the application
// 01182020 rstepp      Added UserInput/number of people in car/References/Output
//
// References Used
// https://alternetrides.com/zz_savings_calculator.asp
// https://www.rideshare.com/easy-commute/commuter-savings-calculator/
// https://511.org/carpool/savings

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

        // Variable for the number of people in the carpool
        private static int peopleInCar = 1;

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
The formula used is:
(((Miles per day / Average MPG) * Cost per gallon of fuel) 
    + Tolls per day + Parking per day) / Number of occupants in vehicle

Please use decimal (9.99) or whole numbers (15) 
and no special characters ($).
");
        }

        // Input from the user
        private static decimal UserInput()
        {
            decimal perUserTotal = 0.0m;
            double calculatedTotal;

            // Assign number of miles driven
            Console.WriteLine("How many miles per day is your commute? (10.2, 15.5, etc)");
            milesDriven = double.Parse(Console.ReadLine());

            // Assign cost of fuel per gallon
            Console.WriteLine("How much (on average) does fuel cost per gallon? ($2.50, $3.49, etc)");
            costFuel = double.Parse(Console.ReadLine());

            // Assign miles per gallon of vehicle
            Console.WriteLine("What is your average miles per gallon? (13, 20.8, etc)");
            avgMPG = double.Parse(Console.ReadLine());

            // Assign parking fees per day
            Console.WriteLine("How much do you pay per day in parking fees? ($5.00, $6, etc)");
            parkingFees = double.Parse(Console.ReadLine());

            // Assign tolls paid per day
            Console.WriteLine("How much do you pay per day in tolls? ($5.00, $7, etc)");
            tollsDay = double.Parse(Console.ReadLine());

            // Assign number of occupants in vehicle
            Console.WriteLine("What is the number of people you wish to be in the carpool? (2, 3, 4)");
            peopleInCar = int.Parse(Console.ReadLine());

            // Calculate how much money is used per day by the vehicle
            calculatedTotal = ((milesDriven / avgMPG) * costFuel) + tollsDay + parkingFees;

            // Take vehicle total and split between occupants
            perUserTotal = Convert.ToDecimal(calculatedTotal / peopleInCar);

            // Round the per user total to 2 digits
            perUserTotal = Decimal.Round(perUserTotal, 2);

            return perUserTotal;
        }

        // Main method that calls other single use methods
        static void Main(string[] args)
        {
            // Display user interface
            UserInterface();

            // Output the calculated total from user input
            Console.WriteLine($"Your per person cost would be: ${UserInput()}");
        }
    }
}
