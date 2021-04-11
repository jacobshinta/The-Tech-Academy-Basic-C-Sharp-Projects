using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    class Program
    {
        static void Main()
        {
            string[] colors = { "red", "blue", "green" }; //create array
            Console.WriteLine("Choose an index for the colors Array."); //ask for an index value
            int userColor = Convert.ToInt32(Console.ReadLine());//store and convert the response
            while (userColor > (colors.Length - 1)) //loop to ask for another number if outside of array length
            {
                Console.WriteLine("Please choose a value between 0 and 2."); //asking for corerect value
                userColor = Convert.ToInt32(Console.ReadLine()); //converting and storing the value
            }
            Console.WriteLine("This is the chosen color: " + colors[userColor]); ; //display chosen color


            int[] numbers = { 5, 10, 15, 20 }; //create array
            Console.WriteLine("Choose an index for the numbers Array."); //ask for the index value
            int userNum = Convert.ToInt32(Console.ReadLine()); //store and convert the variable
            while (userNum > 3) //loop to ask for another response if outside of length of array
            {
                Console.WriteLine("Please choose a value between 0 and 3."); //ask for another number
                userNum = Convert.ToInt32(Console.ReadLine()); //store and conver the number
            }
            Console.WriteLine("This is the chosen number: " + numbers[userNum]); //display chose index value
            

            List<string> colors2 = new List<string>(); //create new list
            colors2.Add("Yellow"); //add these values to list
            colors2.Add("Brown");
            colors2.Add("Pink");

            Console.WriteLine("Choose an index for the colors2 List."); //ask for an index value
            int userColor2 = Convert.ToInt32(Console.ReadLine()); //convert and store the variable
            while (userColor2 > (colors2.Count - 1)) //loop to ask for a correct value
            {
                Console.WriteLine("Please choose a value between 0 and 2."); //display string asking for valid index value
                userColor2 = Convert.ToInt32(Console.ReadLine()); //conver and store var
            }


            Console.WriteLine("This is the chosen color: " + colors2[userColor2]); //display the valid chosen index

            Console.ReadLine();

        }
    }
}
