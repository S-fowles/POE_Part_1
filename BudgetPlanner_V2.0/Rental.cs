using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_V2._0
{
    internal class Rental : Expense
    {
        // Override mehtod from the Expense class
        public override void input()
        {
            Console.Write("Enter the monthly rental amount: ");
            accomodationCost = double.Parse(Console.ReadLine());

        }
    }
}
