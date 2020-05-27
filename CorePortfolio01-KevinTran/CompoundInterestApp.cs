using System;

namespace CorePortfolio01_KevinTran
{
    class CompoundInterestApp
        /*
         * Purpose: To compute and display the future value of an investment using the principal amount, interest rate, number of years, 
         * and the number of times the interest is compounded per year. 
         * 
         * Input: Investment amount, annual interest rate in percentage, compound period, and number of years left to earn interest.
         * 
         * Process: Using the formula where to get the future value, you must determine what the rate of the return is by adding 1 to the annual interest rate divided by compounds.
         * Then you take the principal amount and multiply it with the value of the rate of return to the power of compounds multiplied by the years of the term.
         * 
         * Output: Future value of the investment, investment amount, annual interest rate, compounds per year, and the years of the term.
         * 
         * Author: Kevin Tran
         * 
         * Last Modified: 2019/09/18
         * 
         */
    {
        static void Main(string[] args)
        {
            // ------------ Starting of the Compound Interest App ------------

            Console.WriteLine("-------------------------");
            Console.WriteLine("| Compound Interest App |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("This program is used to calculate the future investment value.\n");

            // ------------ Declaring variables ------------

            double futureValue;
            double principalAmount;
            double annualInterestRate;
            double annualInterestRatePercentage;
            double compoundPeriodDoubleCast;
            double numberOfYearsDoubleCast;
            double compoundedYears;
            double rateOfReturn;
            int compoundPeriod;
            int numberOfYears;
            string userInput;

            // ------------ Asking for user input ------------

            // Investment Amount
            Console.Write("Please enter your investment amount: ");
            userInput = Console.ReadLine();
            principalAmount = double.Parse(userInput);

            // Annual interest rate in percentage
            Console.Write("Please enter the annual interest rate as a percentage of 100: ");
            userInput = Console.ReadLine();
            annualInterestRatePercentage = double.Parse(userInput);
            annualInterestRate = annualInterestRatePercentage / 100;

            // Compound periods 
            Console.WriteLine("(Compound periods can be 1 for yearly, 2 for semi-annually, 4 for quarterly, or 12 for monthly)");
            Console.Write("Please enter the number of compound periods (1,2,4,12): ");
            userInput = Console.ReadLine();
            compoundPeriod = int.Parse(userInput);

            // Number of years 
            Console.Write("Please enter the number of years for the account term: ");
            userInput = Console.ReadLine();
            numberOfYears = int.Parse(userInput);

            // ------------ The process ------------

            compoundPeriodDoubleCast = (double)(compoundPeriod);
            numberOfYearsDoubleCast = (double)(numberOfYears);

            compoundedYears = compoundPeriodDoubleCast * numberOfYearsDoubleCast;
            rateOfReturn = 1 + (annualInterestRate / compoundPeriodDoubleCast);

            futureValue = principalAmount * Math.Pow(rateOfReturn, compoundedYears);
            futureValue = Math.Round(futureValue, 2);

            // ------------ Displaying the output ------------

            Console.WriteLine("\nYour future value is: {0:C}", futureValue);
            Console.WriteLine("Your investment amount is:\t {0:C}", principalAmount);
            Console.WriteLine("Your annual interest rate is:\t {0}%", annualInterestRatePercentage);
            Console.WriteLine("Your compounds per year is:\t {0}", compoundPeriod);
            Console.WriteLine("Your number of years for this term is:\t {0}", numberOfYears);

        }
    }
}
