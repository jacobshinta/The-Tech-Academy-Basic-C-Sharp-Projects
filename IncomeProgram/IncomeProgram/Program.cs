using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program.\nPerson 1.\nHourly Rate?"); //display string with line breaks
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine()); //stores response and converts to double
            Console.WriteLine("Hours worked per week?"); //display string
            double weeklyHours1 = Convert.ToDouble(Console.ReadLine()); //stores response and converts to double
            Console.WriteLine("Person 2.\nHourly Rate?"); //display string
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine()); //stores response and converts to double
            Console.WriteLine("Hours worked per week?"); //display string
            double weeklyHours2 = Convert.ToDouble(Console.ReadLine()); //stores response and converts to double
            double salary1 = hourlyRate1 * weeklyHours1 * 52; //calculate annual salary for person 1
            double salary2 = hourlyRate2 * weeklyHours2 * 52; // same as above for person 2

            Console.WriteLine("Annual salary of person 1: " + salary1); // display the string with the stored value for the persons salary
            Console.WriteLine("Annual salary of person 2: " + salary2); //same as above
            Console.WriteLine("Does Person 1 make more money than Person 2 ? \n" + (salary1 > salary2)); // display whether or not salary  1 is greater than salary 2
            Console.ReadLine();


        }
    }
}
