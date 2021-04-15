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

        public override void SayName()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.ReadLine();
        }
        public void Quit()
        {
            throw new NotImplementedException(); //throw exception
        }

        public static bool operator== (Employee person1, Employee person2) //overload the == operator
        {
            return (person1.Id == person2.Id); //return the result
        }

        public static bool operator!= (Employee person1, Employee person2)
        {
            return (person1.Id != person2.Id);
        }
        
    }
}
