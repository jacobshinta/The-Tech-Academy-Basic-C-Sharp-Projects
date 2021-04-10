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
            Console.WriteLine("Anonymous Income Comparison Program.\nPerson 1.\nHourly Rate?");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double weeklyHours1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 2.\nHourly Rate?");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double weeklyHours2 = Convert.ToDouble(Console.ReadLine());
            double salary1 = hourlyRate1 * weeklyHours1 * 52;
            double salary2 = hourlyRate2 * weeklyHours2 * 52;

            Console.WriteLine("Annual salary of person 1: " + salary1);
            Console.WriteLine("Annual salary of person 2: " + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2 ? \n" + (salary1 > salary2));
            Console.ReadLine();


        }
    }
}
