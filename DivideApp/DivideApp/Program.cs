using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 }; //create list
            Console.WriteLine("Choose a number to divide into each number in a list."); //ask for a number
                try //start try catch block
                {
                int userNumber = Convert.ToInt32(Console.ReadLine()); //store and convert user input
                    foreach (int number in numbers) //loop through each number in the above list
                    {
                        int result = number / userNumber; //store the division as result
                        Console.WriteLine(result); //display result
                    }
                }
                catch (FormatException ex) //catch the designated exception and display the message
                {
                    Console.WriteLine("Please type a whole number.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't divide by 0.");
                }
            Console.WriteLine("Test."); //test that code executes outside of the try catch block
            Console.ReadLine();
        }
    }
}
