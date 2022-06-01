using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1_Rev_2
{
    internal class UserInput : Expense
    {
        /* Override method for the abstract method created in the Expense class
         * This method takes the user input for income and expenses
         */
        public override void input()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" +
                "\n\t\t\t\t\tWelcome to the Personal Budgeting Application" +
                "\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Loading");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(".");
                // Pause for 1 second
                System.Threading.Thread.Sleep(1000); // 1000ms = 1 second. 

            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine();
            // Getting the user input and assigning it to the variables created in abstract Expense class
            Console.Write("Enter your gross monthly income: ");
            grossMonthlyIncome = double.Parse(Console.ReadLine());

            Console.Write("Enter your estimated monthly tax deduction: ");
            estMonthlyTax = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            netIncome = grossMonthlyIncome - estMonthlyTax;

            

            Console.WriteLine("Enter your estimated cost of the following expenses ");
            Console.Write("Groceries: ");
            expensesList.Add(double.Parse(Console.ReadLine()));

            Console.Write("Water & Lights: ");
            expensesList.Add(double.Parse(Console.ReadLine()));

            Console.Write("Travel Costs (Include petrol): ");
            expensesList.Add(double.Parse(Console.ReadLine()));

            Console.Write("Cell Phone & Telephone: ");
            expensesList.Add(double.Parse(Console.ReadLine()));

            Console.Write("Other Expenses: ");
            expensesList.Add(double.Parse(Console.ReadLine()));

            string buyVehicle;
            Console.WriteLine("Would you like to buy a vehicle? ");
            buyVehicle = Console.ReadLine();

            if (string.Equals(buyVehicle, "Yes", StringComparison.OrdinalIgnoreCase))
            {
                Vehicle V = new Vehicle();
                V.userChoice();
                V.vehicleCalculation();
            }

            expensesList.Add(Vehicle.totalVehicleCost);


            // Adding up the values of the list
            totalExp = expensesList.Aggregate((x, y) => x + y);

            expensesList.OrderByDescending(x => x);

            Console.WriteLine(expensesList);
            
            // Calculating the users net income
            netIncome = netIncome - totalExp;



            // Ouput
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Gross Monthly Income: {0:C}" +
                "\nTax: {1:C}" +
                "\nGroceries: {2:C}" +
                "\nWater and Lights: {3:C}" +
                "\nTavel: {4:C}" +
                "\nCell Phone & Telephone: {5:C}" +
                "\nOther Expenses: {6:C}" +
                "\nVehicle Cost: {7:C}" +
                "\nTotal monthly expenses: {8:C}" +
                "\nNet Income: {9:C}",grossMonthlyIncome, estMonthlyTax, expensesList[0], expensesList[1], expensesList[2], expensesList[3], expensesList[4], Vehicle.totalVehicleCost, totalExp, netIncome);

            // While loop to ensure the user input is correct
            while (true)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.Write("Would you like to rent accommodation or purchase a property," +
                    "\nEnter Rent or Buy: ");
                string decision = Console.ReadLine();

                // If statement where the user decides if they would like to rent a property or buy it
                if (string.Equals(decision, "Rent", StringComparison.OrdinalIgnoreCase))
                {
                    Rent R = new Rent();
                    R.input();
                    break;
                }
                else if (string.Equals(decision, "Buy", StringComparison.OrdinalIgnoreCase))
                {
                    HomeLoan HL = new HomeLoan();
                    HL.input();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input is incorrect");
                    Console.ForegroundColor = ConsoleColor.White; 

                }
            }

    }
        // Method that allows the user to reset and reuse the program
        public void reuse()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to reuse the personal budgeting application? " +
                "\nEnter Yes to continue or No to exit: ");
            string exit = Console.ReadLine();

            if (string.Equals(exit, "yes", StringComparison.OrdinalIgnoreCase))
            {
                // Clearing the console of the previous input
                Console.Clear();

                // Clearing the expenses that were stored in a list
                expensesList.Clear();

                // Object created for the UserInput class
                UserInput UI = new UserInput();

                // Calling the overridden method from the UserInput class
                UI.input();
            }
            else
            {
                // Exiting the program
                System.Environment.Exit(0);
            }
        }
}
}
