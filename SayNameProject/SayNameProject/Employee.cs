using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayNameProject
{
    public class Employee : Person //inherit the person class
    {
        public int Id { get; set; } //set a property

        //public void SayName()
        //{
        //    Console.WriteLine("Name: " + FirstName + " " + LastName + " ID #" + Id);
        //    Console.ReadLine();
        //}
    }
}
