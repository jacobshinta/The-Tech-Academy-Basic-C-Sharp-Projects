using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    public class Example
    {
        public static void Method(int x, out int output) //create method 
        {
            output = x / 2; //divide the variable
        }

        public static void Method(int x, int y, out int total)
        {
            total = x + y;
        }  
    }
}
