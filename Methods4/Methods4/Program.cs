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
            Example example = new Example(); //instantiate
            Console.WriteLine("Enter a whole number and we'll divide it by 2."); //ask for variable
            int num = Convert.ToInt32(Console.ReadLine()); //convert and store the input

            example.Method(num, out int x); //call method
            Console.WriteLine(x); //display result

            Console.WriteLine("Enter another number to be added to the result."); //ask for another variable
            int y = Convert.ToInt32(Console.ReadLine()); //store and convert
            example.Method(x, y, out int total); //call method
            Console.WriteLine("The total is: " + total); //display result

            Static.Test(out x); //call method
            Console.WriteLine("This is a test." + x); //display result
            Console.ReadLine();
        }
    }
}
