using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayNameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee(); //instantiate objects
            Employee person2 = new Employee();

            person1.Id = 10; //set their ids
            person2.Id = 10;

            bool result = person1 == person2; //use the overloaded operator to see if their ids are equal and set result to the variable
            Console.WriteLine(result); //display result
            Console.ReadLine();
            

        }
    }
}
