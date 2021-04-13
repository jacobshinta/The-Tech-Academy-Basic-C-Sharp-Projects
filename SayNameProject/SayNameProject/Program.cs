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
            Employee person = new Employee(); //instantiate object
            person.FirstName = "Sample"; //set variables
            person.LastName = "Student";
            //person.Id = 21;

            person.SayName(); //call method
        }
    }
}
