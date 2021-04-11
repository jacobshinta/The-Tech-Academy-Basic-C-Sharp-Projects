using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ShippingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight:"); //display string and ask for weight variable
            double weight = Convert.ToDouble(Console.ReadLine()); //store variable and convert
            if (weight > 50) //if the expression is true display the following
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            Console.WriteLine("Please enter the package width:"); //ask for the dimensions, store and conver the variables
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());
            double total = width + height + length; //add these together for the following if statement
            if (total > 50) //if the statement is true display the following
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            }
            double quote = ((width * height * length) * weight) / 100; //expression for shiiping price
            Console.WriteLine("Your estimated total for this package is: " + quote.ToString("C", CultureInfo.CurrentCulture)); //display the quote as a dollar amount

            Console.ReadLine();
        }
    }
}
