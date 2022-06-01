using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1_Rev_2
{
    internal class Rent : Expense
    {
        // Declaring local variables and get set methods
        public static double rentalAmount { get; set; }
        public double availableMoneyRent { get; set; }
        
        // Override mehtod from the Expense class
        public override void input()
        {
            Console.Write("Enter the monthly rental amount: ");
            rentalAmount = double.Parse(Console.ReadLine());

            // Calculation to determine the available money left over after all deductions have been made
            availableMoneyRent = netIncome - rentalAmount;

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

            // Displaying the users money they will have left at the end of the month, after all deductions 
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("After all expenses have been dedcuted, including the monthly cost of rent, you will have {0:C} left for the month ", availableMoneyRent);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            // Creating an object of the UserInput class 
            UserInput UI = new UserInput();

            // Calling the reuse method from the UserInput class
            UI.reuse();
        }
        
    }
}
