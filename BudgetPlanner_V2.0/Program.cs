using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_V2._0
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Object created for the UserInput class
            UserInput UI = new UserInput();

            // Calling the overridden method from the UserInput class
            UI.input();

            Console.ReadKey();
        }
    }
}
