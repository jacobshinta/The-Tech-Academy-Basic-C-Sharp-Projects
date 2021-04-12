using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsProgram
{
    public class Operation
    {
        public int Add(int userInput) //creating method
        {
            userInput = userInput + 10; //adding 10 to the input and restoring the value
            return userInput;
            
        }
        public int Subtract(int userInput2)
        {
            userInput2 = userInput2 - 10;
            return userInput2;

        }
        public int Multiply(int userInput3)
        {
            userInput3 = userInput3 * 10;
            return userInput3;

        }
    }
        

    
}
