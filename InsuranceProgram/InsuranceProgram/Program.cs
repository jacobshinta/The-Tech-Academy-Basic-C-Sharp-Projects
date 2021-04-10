using System;

namespace InsuranceProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Do you qualify for car insurance?\nWhat is your age?"); //ask for age
            int age = Convert.ToInt32(Console.ReadLine()); //store and convert age to int
            bool ageResult = age > 15; //store bool

            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\""); //ask for true or false
            bool dui = Convert.ToBoolean(Console.ReadLine()); //store and convert string to bool
            
            Console.WriteLine("How many speeding tickets do you have?"); //ask how many tickets
            int tickets = Convert.ToInt32(Console.ReadLine()); //store and convert to int
            bool ticketsResult = tickets <= 3; //store bool for tickets are less than or equal to 3
            
            bool status = ageResult && ticketsResult && !dui; //store bool for parameters designated
            Console.WriteLine("Qualified?\n" + status); //display the stored bool for qualification status
            Console.ReadLine();
            

        }
        
    }
}
