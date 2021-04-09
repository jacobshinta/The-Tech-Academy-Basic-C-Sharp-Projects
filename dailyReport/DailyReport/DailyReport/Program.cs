using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy. \nStudent Daily Report. \nWhat is your name?"); //write string to console with line breaks
            string yourName = Console.ReadLine(); //store your name as a string
            
            Console.WriteLine("What course are you on?"); //print asking what course you are on
            string courseName = Console.ReadLine(); //store the answer as astring
           
            Console.WriteLine("What page number?"); //ask what page
            string pageNo = Console.ReadLine(); //store as a string
            int pgNo = Convert.ToInt32(pageNo); //convert to a int
            
            Console.WriteLine("Do you need help with anything? Answer \"true\" or \"false\"." ); //ask if any help is needed
            string anyHelp = Console.ReadLine();//store the answer as a tstring
            bool boolHelp = Convert.ToBoolean(anyHelp); //convert the stored answer to a bool
            
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); //print the question
            string posExp = Console.ReadLine(); //store the response as a string
            
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); //print the question
            string feedback = Console.ReadLine(); //store response
            
            Console.WriteLine("How many hours did you study today?"); //print the question
            string studyHours = Console.ReadLine(); //store answer as a string
            int hours = Convert.ToInt32(studyHours); //conver the answer to an int

            Console.WriteLine("Thank your for your answers. An instructor will respond to this shortly. Have a great day!"); //print the goodbye message
            Console.ReadLine();



        }
    }
}
