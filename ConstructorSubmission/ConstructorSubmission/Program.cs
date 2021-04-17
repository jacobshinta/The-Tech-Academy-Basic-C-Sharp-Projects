using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Jacob"; //set constant variable
            var name2 = "James"; //set implied variable
            Console.WriteLine(name2); //display the variable
            Console.ReadLine();

            var fullName = new Names("Jacob"); //instantiate object
            Console.WriteLine(fullName.forename + " " + fullName.surname); //display name
            Console.ReadLine();
        }
        public class Names
        {
            public Names(string first, string last) //constructor to set the variable
            {
                forename = first;
                surname = last;
            }

            public Names(string last) : this(last, "Long")
            {

            }

            public string forename { get; set; }
            public string surname { get; set; }
        }
    }
}
