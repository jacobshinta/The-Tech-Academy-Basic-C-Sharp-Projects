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
            Employee employee = new Employee(); //instantiate object
            employee.FirstName = "Sample"; //set variables
            employee.LastName = "Student";
            //person.Id = 21;

            employee.SayName(); //call method

            IQuittable quittable = new Employee(); 
            
            quittable.Quit();
            

        }
    }
}
