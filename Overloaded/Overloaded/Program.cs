using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations opClass = new Operations(); //create new variable

            int inputInt = 10; //create variables for operations
            double inputDec = 1.5;
            string inputString = "10";

            inputInt = opClass.Method(inputInt); //set the variables equal to the result of the method with the inputted value
            inputDec = opClass.Method(inputDec);
            inputString = opClass.Method(inputString);

            Console.WriteLine(inputInt + ", " + inputDec + ", " + inputString); //write the result
            Console.ReadLine();
        }
    }
}
