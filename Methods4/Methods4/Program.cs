using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number and we'll divide it by 2."); //ask for variable
            int num = Convert.ToInt32(Console.ReadLine()); //convert and store the input

            Example.Method(num, out int x); //call method
            Console.WriteLine(x); //display result

            Console.WriteLine("Enter another number to be added to the result."); //ask for another variable
            int y = Convert.ToInt32(Console.ReadLine()); //store and convert
            Example.Method(x, y, out int total); //call method
            Console.WriteLine("The total is: " + total); //display result
            Console.ReadLine();
        }
    }
}
