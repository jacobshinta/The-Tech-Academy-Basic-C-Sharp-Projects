using System;

namespace InsuranceProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Do you qualify for car insurance?\nWhat is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool ageResult = age > 15;
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool ticketsResult = tickets <= 3;
            bool status = ageResult && ticketsResult && !dui;
            Console.WriteLine("Qualified?\n" + status);
            Console.ReadLine();
            

        }
        
    }
}
