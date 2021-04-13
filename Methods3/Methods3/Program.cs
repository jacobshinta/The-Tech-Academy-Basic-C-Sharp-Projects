using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestC testC = new TestC(); //instantiate the calss and call the method with these parameters
            testC.Method(5, 10);
        }
    }
}
