using SugarDrinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Drinks drinks = new Drinks("Breckenridge Brewing");
            Soda soda = new Soda("Coke");

            var myAnonymousClass = new { Name = "Bret", Handle = "@Bret" };
            Console.WriteLine(myAnonymousClass.Name);
        }
    }
}
