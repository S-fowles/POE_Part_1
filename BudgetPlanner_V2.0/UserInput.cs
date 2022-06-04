using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_V2._0
{
    internal class UserInput : Expense
    {
        // Created Delegates globally, pointing to the warningMsg method 
        public delegate void warningMsgDelegate();
        public delegate void detailedOutputDelegate();
        public delegate void moneyRemainingDelegate();
        public delegate void reuseDelegate();

        /* Override method for the abstract method created in the Expense class
        * This method takes the user input for income and expenses
        */
        public override void input()
        {
            // Creating an object of the Vehicle class
            Vehicle V = new Vehicle();

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

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            // While loop to ensure the user inputs either yes or no when asked if they would like to purchase a vehicle
            while (true)
            {
                string buyVehicle;
                Console.WriteLine("Would you like to buy a vehicle? ");
                Console.Write("Enter Yes or No: ");

                buyVehicle = Console.ReadLine();

                if (string.Equals(buyVehicle, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    V.userChoice();
                    V.vehicleCalculation();
                    V.output();
                    break;
                }
                else if (string.Equals(buyVehicle, "No", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input is incorrect!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // Adding up the values of the list
            totalExp = expensesList.Aggregate((x, y) => x + y);
            totalExp = totalExp + estMonthlyTax;

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
                    Rental R = new Rental();
                    R.input();
                    break;
                }
                else if (string.Equals(decision, "Buy", StringComparison.OrdinalIgnoreCase))
                {
                    HomeLoan HL = new HomeLoan();
                    HL.homeLoanInput();
                    HL.homeLoanCalculation();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input is incorrect!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // Sorting the list 
            expensesList.Sort();
            // Reversing the sort so it displays in descending order
            expensesList.Reverse();

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Calculating Monthly Expenses");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(".");
                // Pause for 1 second
                System.Threading.Thread.Sleep(1000); // 1000ms = 1 second. 

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            int num = 1;
            Console.WriteLine();
            Console.WriteLine("List of monthly expenses in descending order: ");
            Console.WriteLine();

            foreach (double expense in expensesList)
            {
                Console.WriteLine(num + ". " + "R{0} ", expense);
                num++;
            };
            Console.WriteLine();

            Console.WriteLine("Estimated Tax R{0}", estMonthlyTax);
            Console.WriteLine("Vehicle Cost: R{0}", Vehicle.totalVehicleCost);
            // Rounding the accomodation cost to 2 decimal places
            Console.WriteLine("Accomodation Cost: R{0}", Math.Round(accomodationCost, 2));

            totalExp = (totalExp + Vehicle.totalVehicleCost + accomodationCost);

            // Calculating the users net income
            netIncome = grossMonthlyIncome - totalExp;

            // If statement warning the user that their total expenses exceed 75% of their net income
            if (totalExp >= (netIncome * 0.75))
            {
                // Annonymous method using a delegate
                warningMsgDelegate wmd = delegate ()
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WARNING!\nYour total expenses exceed 75% of your net income!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                };
                // Method call using .Invoke()
                wmd.Invoke();
            }

            // Create an object of the delegate -- pass the name of the method into it
            moneyRemainingDelegate mrd = new moneyRemainingDelegate(moneyRemaining);
            // Calling the method
            mrd();

            detailedOutputDelegate dod = new detailedOutputDelegate(detailedOutput);
            // Another way to call a method
            dod.Invoke();

            reuseDelegate rud = new reuseDelegate(reuse);
            rud();
        }

        // Method that allows the user to reset and reuse the program
        public void reuse()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to reuse the personal budgeting application? ");
            Console.Write("\nEnter Yes to continue or No to exit: ");
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

        // A method that asks the user if they would like to view a more detailed output of their income and expenses
        public void detailedOutput()
        {
            while (true)
            {
                string detailedDisp;
                Console.WriteLine();
                Console.WriteLine("Would you like to view a detailed list of your monthly expenses showing total expenses and net income? ");
                Console.Write("Enter Yes or No: ");
                detailedDisp = Console.ReadLine();

                if (string.Equals(detailedDisp, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    // Ouput of detailed list of expenses
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Gross Monthly Income: R{0}" +
                        "\nTax: R{1}" +
                        "\nGroceries: R{2}" +
                        "\nWater and Lights: R{3}" +
                        "\nTavel: R{4}" +
                        "\nCell Phone & Telephone: R{5}" +
                        "\nOther Expenses: R{6}" +
                        "\nTotal Vehicle Cost (including insurance): R{7}" +
                        "\nTotal Accomodation Cost: R{8}" +
                        "\nTotal Monthly Expenses: R{9}" +
                        "\nNet Income: R{10}", grossMonthlyIncome, estMonthlyTax, expensesList[0], expensesList[1], expensesList[2], expensesList[3], expensesList[4], Vehicle.totalVehicleCost, Math.Round(accomodationCost, 2), Math.Round(totalExp, 2), Math.Round(netIncome, 2));
                    break;
                }
                else if (string.Equals(detailedDisp, "No", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input is incorrect!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        // Method that displays the net income or left over money at the end of the month, after all deductions have been made
        public void moneyRemaining()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Calculating available money left over after deductions");

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
            Console.WriteLine("After all deductions, you will have R{0} left over for the month ",Math.Round(netIncome, 2));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
