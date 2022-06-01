using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1_Rev_2
{
    internal class HomeLoan : Expense
    {
        // local varaibles and get set methods
        public double propertyPrice { get; set; }
        public double deposit { get; set; }
        public double propertyPriceMinusDeposit { get; set; }
        public double interestRate { get; set; }    
        public double numOfMonths { get; set; }
        public double monthlyRepayement { get; set; }
        public double availableMoney { get; set; }
        
        /* Override method form Expense class
         * This method takes the user input for the questions pertaining to purchasing a house
         */
        public override void input()
        {
            Console.Write("Enter the price of the property you are wanting to purchase: ");
            propertyPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the total deposit: ");
            deposit = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            interestRate = double.Parse(Console.ReadLine());

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
                    monthlyRepayement = propertyPriceMinusDeposit * (1 + interestRate * numOfMonths);
                    monthlyRepayement = monthlyRepayement / (numOfMonths * 12);

                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Your monthly pament on a property costing {0:C}, with a deposit of {1:C}, is: {2:C}\n ", propertyPrice, deposit, monthlyRepayement);

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
            if (monthlyRepayement > (grossMonthlyIncome / 3))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WARNING!\nIt is unlikely your bond will get approved!\n" +
                    "Your monthly repayment is more than one third of your gross income.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It is likely your bond will get approved!\n");
                Console.ForegroundColor = ConsoleColor.White;

            }

            // Calculation to determine the available money left over after all deductions have been made
            availableMoney = netIncome - monthlyRepayement;

            // Displaying the users money they will have left at the end of the month, after all deductions 
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("After all deductions, including the monthly repayment on your bond, you will have {0:C} left for the month ", availableMoney);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            // Creating an object of the UserInput class 
            UserInput UI = new UserInput();

            // Calling the reuse method from the UserInput class
            UI.reuse(); 
        }

    }
}
