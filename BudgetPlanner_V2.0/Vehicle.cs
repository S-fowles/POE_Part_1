using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_V2._0
{
    internal class Vehicle : Expense
    {
        // Static variables to hold details about the vehicle
        public static string vehicleMake { get; set; }
        public static string vehicleModel { get; set; }
        public static double vehiclePrice { get; set; }
        public static double Vehicledeposit { get; set; }
        public static double vehicleIntRate { get; set; }
        public static double premium { get; set; }
        public static double vehicleRepayment { get; set; }
        public static double totalVehicleCost { get; set; }


        // Empty overridden method from the Expenses class
        public override void input()
        {
            
        }

        // Method to take user input about the purchase of a vehicle
        public void userChoice()
        {
            Console.Write("Enter the make of the vehicle: ");
            vehicleMake = Console.ReadLine();

            Console.Write("Enter the model of the vehicle: ");
            vehicleModel = Console.ReadLine();

            Console.Write("Enter the purchase price of the vehicle: ");
            vehiclePrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the total deposit you are paying on the vehicle: ");
            Vehicledeposit = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate on the vehicle loan: ");
            vehicleIntRate = double.Parse(Console.ReadLine());

            Console.Write("Enter the estimate insurance premium for the vehicle: ");
            premium = double.Parse(Console.ReadLine());

        }

        // Method to calculate the total cost of the vehicle 
        public double vehicleCalculation()
        {
            vehicleIntRate = vehicleIntRate / 100;
            vehiclePrice = vehiclePrice - Vehicledeposit;
            vehicleRepayment = vehiclePrice * (1 + vehicleIntRate * 5);
            vehicleRepayment = vehicleRepayment / (5 * 12);

            totalVehicleCost = vehicleRepayment + premium;

            return totalVehicleCost;
        }

        // Method with a out of the vehicle details and total cost
        public void output()
        {
            Console.WriteLine();
            Console.WriteLine("The repayment on an {0} {1} costing R{2} (deposit deducted), inclusive of insurance is: R{3} monthly", vehicleMake, vehicleModel, vehiclePrice, totalVehicleCost);
        }

    }
}

