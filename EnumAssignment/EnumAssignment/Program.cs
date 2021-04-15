using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the current day of the week.");
            string currentDay = Console.ReadLine();
            try
            {
                Days thisDay = (Days)Enum.Parse(typeof(Days), currentDay.ToLower());
                Console.Write("You've entered " + currentDay.ToLower());
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            Console.ReadLine();

        }

        public enum Days
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
    }
}
