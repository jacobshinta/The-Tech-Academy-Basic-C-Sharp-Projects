using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayNameProject
{
    public class Person
    {
        public string FirstName { get; set; } //set properties
        public string LastName { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //display name
            Console.Read();
        }
    }
}
