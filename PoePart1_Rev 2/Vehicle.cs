using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1_Rev_2
{
    internal class Vehicle : Expense
    {

        public static string vehicleMake { get; set; }
        public static string vehicleModel { get; set; }
        public static double vehiclePrice { get; set; }
        public static double Vehicledeposit { get; set; }
        public static double vehicleIntRate { get; set; }
        public static double premium { get; set; }
        public static double vehicleRepayment { get; set; }
        public static double totalVehicleCost { get; set; }

        public override void input()
        {
            throw new NotImplementedException();
        }

        public void userChoice()
        {
            Console.WriteLine("Enter the make of the vehicle: ");
            vehicleModel = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle: ");
            vehicleModel = Console.ReadLine();

            Console.WriteLine("Enter the purchase price of the vehicle: ");
            vehiclePrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total deposit you are paying on the vehicle: ");
            Vehicledeposit = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the interest rate on the vehicle loan: ");
            vehicleIntRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the estimate insurance premium for the vehicle: ");
            premium = double.Parse(Console.ReadLine());


        }

        public double vehicleCalculation()
        {
            vehicleIntRate = vehicleIntRate / 100;
            vehiclePrice = vehiclePrice - Vehicledeposit;
            vehicleRepayment = vehiclePrice * (1 + vehicleIntRate * 5);
            vehicleRepayment = vehicleRepayment / (5 * 12);

            totalVehicleCost = vehicleRepayment + premium;

            return totalVehicleCost;
    }
    }
    
}
