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
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); //print this
            bool another = false; //set initial value for another package
            double subTotal = 0; //initial value of subtotal
            do //start loop. probably not necessary to be a do loop but just doing it for the purpose of practice
            {
                Console.WriteLine("Please enter the package weight:"); //display string and ask for weight variable
                double weight = Convert.ToDouble(Console.ReadLine()); //store variable and convert
                if (weight > 50) //if the expression is true display the following
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express.\nWould you like to ship a different package? Please answer \"true\" or \"false\""); //print and ask if theyd like to ry another package
                    bool tooHeavy = Convert.ToBoolean(Console.ReadLine()); //store and convert answer to boolean
                    another = tooHeavy; //set the another variable to their answer so the while loop responds correctly
                    if (tooHeavy == true) 
                    {
                        continue; //start from the top of the initial do loop if they have another package
                    }
                    else
                    {
                        break; //break the loop if they do not have another package
                    }
                }
                Console.WriteLine("Please enter the package width:"); //ask for the dimensions, store and convert the variables
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());
                double total = width + height + length; //add these together for the following if statement
                if (total > 50) //same as above if loop on line 21 just different variable
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.\nWould you like to ship a different package? Please answer \"true\" or \"false\"");
                    bool tooBig = Convert.ToBoolean(Console.ReadLine());
                    another = tooBig;
                    if (tooBig == true)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                double quote = ((width * height * length) * weight) / 100; //expression for shiiping price
                Console.WriteLine("Your estimated total for this package is: " + quote.ToString("C", CultureInfo.CurrentCulture)); //display the quote as a dollar amount
                subTotal = subTotal += quote; //and the current quote price to a running subtotal
                Console.WriteLine("Your estimated total for this order is: " + subTotal.ToString("C", CultureInfo.CurrentCulture)); //display the total amount for order
                Console.WriteLine("Do you have another package? Please answer \"true\" or \"false\""); //ask if they have another package
                another = Convert.ToBoolean(Console.ReadLine()); //converts response to a boolean to determine if the loop will run again
                
            }

            while (another == true); //if they answer true to the previous question the loop repeats
            Console.WriteLine("Your Grand Total is: " + subTotal.ToString("C", CultureInfo.CurrentCulture) + "\nThank you for choosing Package Express! Have a nice day!"); //displays the grand total as a final message
            Console.ReadLine();
        }
    }
}
