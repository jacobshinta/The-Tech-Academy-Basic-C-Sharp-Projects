using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operation operations = new Operation(); //create bariable and set it to new method

            Console.WriteLine("Please choose a number to operate on."); //asks for  a number
            int userInput = Convert.ToInt32(Console.ReadLine()); //converts and stores the number
            int userInput2 = userInput; // store as a different variable
            int userInput3 = userInput;

            userInput = operations.Add(userInput); //calls other methods
            userInput2 = operations.Subtract(userInput2);
            userInput3 = operations.Multiply(userInput3);

            Console.WriteLine(userInput + " " + userInput2 + " " + userInput3); //displays result
            Console.ReadLine();
        }

        
    }
}
