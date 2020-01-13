// Robert Stepp
// TINFO 200
// Cs1 Apps / DigitParser
///////////////////////////////
//Change History
// Date     Developer   Description
//01132020  rstepp      File creation and initial implementation of the application
//
// References Used
// About Adult BMI. (2017, August 29). Retrieved from 
//     https://www.cdc.gov/healthyweight/assessing/bmi/adult_bmi/index.html.
// CoolDadTX. (2015, December 15). Retrieved from 
//     https://social.msdn.microsoft.com/Forums/vstudio/en-US/78d1796e-a481-45ef-92c5-c8e25197bc3d/how-to-round-to-one-decimal-place?forum=csharpgeneral.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMass
{
    class Program
    {
        // Variable for the type of calculator (1=imperial, 2=metric)
        private static int typeCalculator;

        // Variable for the weight entered.
        private static double weight;

        // Variable for the height entered.
        private static double height;

        // Variable for the BMI
        private static decimal bodyMassIndex;

        // Display method to provide user information on the program.
        private static void UserInterface()
        {
            // User Interface
            // Describes use of the program and input information.
            Console.WriteLine(@"
************************************
** Welcome to the BMI Caclculator **
************************************
This program is designed to output the 
users Body Mass Index. It can use decimal
numbers as input.

Please ensure you choose the correct 
input type as it will affect the output.
");
        }

        // Sets the calculator type. This allows the use of both metric and imperial measurements.
        private static void TypeSelector()
        {
            Console.WriteLine("Please enter either 1 for Imperial (pounds/inches) or 2 for Metric (kilograms/meters): ");
            int received = int.Parse(Console.ReadLine());
            if (received == 1 || received == 2) {
                typeCalculator = received;
            } else
            {
                Console.WriteLine($"************************************\n{received} is an invalid selection. Please retry.");                
                TypeSelector();
            }
        }

        // Calculator selection
        private static void CalculatorSelection()
        {
            if (typeCalculator == 1)
            {
                // Imperial (pounds/inches) Calculator

                // Weight input
                Console.WriteLine("Please enter your weight in pounds (eg 195.4, 182.6, etc): ");
                
                // Assign weight to variable
                weight = Double.Parse(Console.ReadLine());

                // Height input
                Console.WriteLine("Please enter your height in inches (eg 72.5, 68.2, etc): ");

                // Assign height to variable
                height = Double.Parse(Console.ReadLine());

                // Caclulate result
                ImperialCalculator();

            } else
            {
                // Metric (kilograms/meters) Calculator

                // Weight input
                Console.WriteLine("Please enter your weight in kilograms (eg 80.7, 85.2, etc): ");

                // Assign weight to variable
                weight = Double.Parse(Console.ReadLine());

                // Height input
                Console.WriteLine("Please enter your height in inches (eg 1.8, 1.6, etc): ");

                // Assign height to variable
                height = Double.Parse(Console.ReadLine());

                // Caclulate result
                MetricCalculator();
            }
        }

        // Imperial Calculator (weight (lb) / (height (in))^2) x 703
        // Formula used from CDC.gov
        // Rounding info from microsoft.com
        private static void ImperialCalculator()
        {
            double bmi = weight / (height * height) * 703;
            bodyMassIndex =  Math.Round(Decimal.Parse(bmi.ToString()), 1);
        }

        // Metric Calculator weight (kg) / (height (m)^2)
        // Formula used from CDC.gov
        // Rounding info from microsoft.com
        private static void MetricCalculator()
        {
            double bmi = weight / (height * height);
            bodyMassIndex = Math.Round(Decimal.Parse(bmi.ToString()), 1);
        }

        // Output the information created/input to the screen.
        private static void ScreenOutput()
        {
            string[] units = new string[2];
            if (typeCalculator == 1)
            {
                units[0] = "inches";
                units[1] = "pounds";
            } else
            {
                units[0] = "meters";
                units[1] = "kilograms";
            }
            Console.WriteLine($@"
***********************************
***** Body Mass Index Results *****
***********************************
With a height of {height} {units[0]}
and a weight of {weight} {units[1]}, 
your body mass index is {bodyMassIndex}.");
            BMICategory();
        }

        // Determine and print BMI Category
        /*  Underweight:  less than 18.5
            Normal:       between 18.5 and 24.9
            Overweight:   between 25 and 29.9
            Obese:        30 or greater
            */
        private static void BMICategory()
        {
            // Needed to convert decimal to double
            double roundedBMI = Double.Parse(bodyMassIndex.ToString());
            
            if (roundedBMI < 18.5)
            {
                // Underweight
                Console.WriteLine("You are underweight.");
            } else if (roundedBMI >= 18.5 && roundedBMI < 25)
            {
                // Normal
                Console.WriteLine("You have a normal weight.");
            } else if (roundedBMI >= 25 && roundedBMI < 30)
            {
                // Overweight
                Console.WriteLine("You are overweight.");
            } else
            {
                // Obese
                Console.WriteLine("You are obese.");
            }
        }

        // Main method that calls other single use methods
        static void Main(string[] args)
        {
            UserInterface();
            TypeSelector();
            CalculatorSelection();
            ScreenOutput();
        }
    }
}
