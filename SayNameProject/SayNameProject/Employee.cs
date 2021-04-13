using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayNameProject
{
    public class Employee : Person, IQuittable //inherit the person class
    {
        public int Id { get; set; } //set a property

        public void Quit()
        {
            throw new NotImplementedException(); //throw exception
        }

        //public void SayName()
        //{
        //    Console.WriteLine("Name: " + FirstName + " " + LastName + " ID #" + Id);
        //    Console.ReadLine();
        //}
    }
}
