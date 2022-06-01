using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1_Rev_2
{
    public abstract class Expense
    {
        // Creating static variables with get set methods
        public static double grossMonthlyIncome { get; set; }
        public static double estMonthlyTax { get; set; }

        public static List<double> expensesList = new List<double>();
        public static double netIncome { get; set; }
        public static double totalExp { get; set; }




        // Creating an abstract method call input
        public abstract void input();

    }
}
