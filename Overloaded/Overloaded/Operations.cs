using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded
{
    class Operations
    {
        public int Method(int inputInt) //method that takes in the input integer
        {
            inputInt = inputInt + 5; //set variable = to operation
            return inputInt;
        }

        public double Method(double inputDec) //same as above except with a double
        {
            inputDec = inputDec * 5;
            return inputDec;
        }

        public string Method(string inputString)
        {
            int intString = Convert.ToInt32(inputString); //convert the string to an integer to use and then do the operation and output the result
            intString = intString / 5;
            inputString = Convert.ToString(intString);
            return inputString;
        }
    }
}
