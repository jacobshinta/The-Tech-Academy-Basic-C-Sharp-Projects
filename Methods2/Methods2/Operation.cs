﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Operation
    {
        public void Method(int input1, int input2 = 0) //create method with optional parameter = 0 so it doesnt add anything
        {
            int result = input1 + input2; //simple equation
            Console.WriteLine(result);
        }
    }
}
