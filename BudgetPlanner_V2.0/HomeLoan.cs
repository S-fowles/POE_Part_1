using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_V2._0
{
    internal class HomeLoan : Expense
    {
        // local varaibles and get set methods
        public double propertyPrice { get; set; }
        public double deposit { get; set; }
        public double propertyPriceMinusDeposit { get; set; }
        public double interestRate { get; set; }
        public double numOfMonths { get; set; }

        
        // Method that takes input about the home loan from the user
        public void homeLoanInput()
        {
            Console.Write("Enter the price of the property you are wanting to purchase: ");
            propertyPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the total deposit: ");
            deposit = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            interestRate = double.Parse(Console.ReadLine());
        }
        
        // Method that does the calculations for the home loan, based on the user input
        public void homeLoanCalculation()
        {
            // Try catch used if the user enters input that is not recognized or if there is a problem with the calculation
            try
            {
                // Calculation to convert interest rate into a percentage
                interestRate = interestRate / 100;

            // While loop to ensure the user inputs a number of months between 240 and 360 
            while (true)
            {
                Console.Write("Enter the number of months the home loan will be taken for," +
                              "\nThis needs to be between 240 & 360 months: ");
                numOfMonths = double.Parse(Console.ReadLine());

                if (numOfMonths >= 240 && numOfMonths <= 360)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Calculating");

                    // For loop that counts to four while outputting full stops, before continue'ing with the program
                    for (int i = 4; i > 0; i--)
                    {
                        Console.Write(".");
                        // Pause for 1 second
                        System.Threading.Thread.Sleep(1000); // 1000ms = 1 second. 

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    numOfMonths = numOfMonths / 12;
                    propertyPriceMinusDeposit = propertyPrice - deposit;
                    accomodationCost = propertyPriceMinusDeposit * (1 + interestRate * numOfMonths);
                    accomodationCost = accomodationCost / (numOfMonths * 12);

                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Your monthly pament on a property costing R{0}, with a deposit of R{1}, is: R{2}\n ", propertyPrice, deposit, Math.Round(accomodationCost, 2));
                    break;
                }
                else
                {

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input is incorrect");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }

            }

            /* If statement that determines if the users monthly repayment is greater than a third of their gross monthly income
             * If the users monthly repayment is greater than 1 third of their gross monthly income, they will be issued with a warning message.
             */
            if (accomodationCost > (grossMonthlyIncome / 3))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WARNING!\nIt is unlikely your bond will get approved!\n" +
                    "Your monthly repayment is more than one third of your gross income.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        catch (global::System.Exception)
	{
                Console.WriteLine("Error, please check input!");
                homeLoanCalculation();       
	}
}
        // Empty overridden method from the Expenses class
        public override void input()
        {
           
        }
    }
}
