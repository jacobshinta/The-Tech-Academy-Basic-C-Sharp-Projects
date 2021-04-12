using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation opClass = new Operation(); 
            Console.WriteLine("Type an integer to add."); //ask for integer
            int input1 = Convert.ToInt32(Console.ReadLine()); //convert and store the variable
            Console.WriteLine("Optionally enter a second integer or press enter to continue."); //ask for optional second integer
            string input2 = Console.ReadLine(); //store it as a string in case they choose to leave it blank
            if (input2 =="") //if statement for if its blank to run with the optional parameter
            {
                opClass.Method(input1);
            }
            else
            {
                int input2Convert = Convert.ToInt32(input2); //convert the variable toan integer and run the method
                opClass.Method(input1, input2Convert);
            }
            
            Console.ReadLine();

        }
    }
}
