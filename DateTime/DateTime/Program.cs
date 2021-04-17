using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; //set a variable to the current date and time
            Console.WriteLine("The current date and time is: " + now); //display it
            Console.WriteLine("Give us a number of hours to add to the current time."); //request a variable
            int user = Convert.ToInt32(Console.ReadLine()); //convert and store the variable
            DateTime result = now.AddHours(user); //use the addhours method to create a new variable with the result
            Console.WriteLine("The result is: " + result); //display the result
            Console.ReadLine();
        }
    }
}
