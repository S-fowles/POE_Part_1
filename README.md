** Personal Budgeting Application **

Version: 2.0

 Software Requirements:
	- Visual Studio 2022
	- NET Framework Version v.4.7.2

Hardware Requirements: 
-	Intel Core i3 (sixth generation or newer) or equivalent
-	4GB Ram
-	250GB Storage
-	Microsoft Windows 10 32-bit(x86) or 64-bit(x64)
-	15” LCD Monitor


** Description **

The personal budgeting application allows you to plan your finances by allowing you to enter your income, 
tax and expenses and then calculate the money left over at the end of the month. 
The application will also allow you to plan for the expense of rent or a bond when purchasing a property, 
you will be given an indication which is based on the information provided by the
user as to the likelihood of your bond being approved. 
The input may be cleared and the program reused. 

** Installation Instructions – .NET Framework **

1.	Download .NET Framework version 4.7.2
-	https://dotnet.microsoft.com/en-us/download/dotnet-framework
2.	Follow the prompts to install

** Running The Application **

1.	Unzip zipped folder named: BudgetPlanner_V2.0
2.	Double click folder unzipped folder named: BudgetPlanner_V2.0
3.	Open: BudgetPlanner_V2.0 folder
4.	Open Bin folder
5.	Open Debug folder
6.	Double click BudgetPlanner_V2.0 application

** Instructions Opening in Visual Studio 2022 **

1.	Unzip folder named: BudgetPlanner_V2.0
2.	Double click BudgetPlanner_V2.0.sln
3.	Press F5 on the keyboard to run the program

** Steps To Use the Application **

1.	Enter your gross monthly income (income before tax or any other deductions)
2.	Enter the amount you will be taxed
3.	Enter some basic monthly expenses
4.	Choose if you would like to purchase a vehicle
5.	If yes enter vehicle details
6.	Choose if you would like to rent or purchase a property, incorrect input here will display an error and reprompt for input

** Rent **

1.	When choosing to rent, you will be prompted to enter the monthly rental amount
2.	The application will then calculate the money left over after all deductions (tax, expenses and rent)
3.	Expenses will be displayed in descending order
4.	User can choose if they would like a detailed list of their expenses, gross income, net income and loan expenses
5.	If expenses exceed 75% of your net income, a warning will be displayed 
6.	Decide if you would like to reuse the program or exit

** Purchase **

1.	When choosing to purchase, you will be prompted to enter the total cost of the house
2.	Enter the deposit amount
3.	Enter the interest rate
4.	Enter the number of months you want to repay the bond for, incorrect    input here will display an error and reprompt for input
5.	Decide if you would like to reuse the program or exit
6.	If your bond is more than a third of your gross income, a warning message will be displayed
7.	The application will calculate the remaining money left at the end of the month

** Detailed Output **

1.	The application will ask if you would like to view a detailed list which includes gross income, all expenses, loan amounts with details as well as total monthly expenses and net income 
2.	The application will then ask if you would like to reuse the program

** FAQ **

1.	Is it possible to keep my values stored for the next time I run the program?
•	This is not a feature that is being used at this time, when you restart or reuse the program, all previously entered values are cleared

2.	Can I run the application without having Visual Studio 2022 installed on my computer?
•	It is possible to run the application in the console, please follow the ** running the application ** instructions at the top of this document

3.	Is it possible for me to add more than one vehicle?
•	Currently this is not possible on this version of the application

4.	What is meant by ‘other’ expenses?
•	These are any expenses that are outside of the expenses listed. Entertainment, clothing, internet costs are some examples

** Developer Details **

Name: Sean Fowles
Email: fowlessean@yahoo.com

Please send any bugs encountered to the email address above

GitHub Repository Link: https://github.com/S-fowles/POE_Part_1

** References **

Doyle, B., n.d. C# programming. 5th ed Cengage

Siyavula.com. 2022. 9.4 Calculations using simple and compound interest | Finance and growth | Siyavula. [online] Available at: <https://www.siyavula.com/read/maths/grade-10/finance-and-growth/09-finance-and-growth-03> [Accessed 10 May 2022]

Umass.edu. 2022. Recommended & Minimum Computer Configurations for Students (Windows) | UMass Amherst Information Technology | UMass Amherst. [online] Available at: <https://www.umass.edu/it/support/hardware/recommended-minimum-computer-configurations-windows> [Accessed 2 June 2022]

Changelog - Part 1:
•	Added try catch to the calculation to check for correct user input and the calculation itself.
•	Added vehicle class – Asks user if they would like to purchase a vehicle and output the monthly cost and vehicle details.
•	Display expenses in descending order, offer a detailed list of expenses to show what each expense is for, total expenses, gross and net income, cost of vehicle and accommodation.
•	Updated readme to include the following:
	Developer/ Author details (name, email)
	Hardware requirements
	Updated software requirements (net framework version)
	Added installation instructions for net framework
	Improved instructions on how to run the application
	Add FAQs
	Gitub repository link added
	Added code attribution
•	Updated Github repository (added new branch)
•	Added Kanban board (Screenshots included below in this document)
•	Removed currency formatting, instead hard coded R to indicate Rands. Used Math.Round to round off numbers to 2 decimal places.

** Kanban Board **
GitHub Link: https://github.com/users/S-fowles/projects/3
 



 

 




