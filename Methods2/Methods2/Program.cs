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
            Console.WriteLine("Type an integer to add.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optionally enter a second integer or press enter to continue.");
            string input2 = Console.ReadLine();
            if (input2 =="")
            {
                opClass.Method(input1);
            }
            else
            {
                int input2Convert = Convert.ToInt32(input2);
                opClass.Method(input1, input2Convert);
            }
            
            Console.ReadLine();

        }
    }
}
