using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1_Rev_2
{
    internal class Program
    {
        /*
         * REFERENCES 
         * Doyle, B., n.d. C# programming. 5th ed. Cengage. */

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
