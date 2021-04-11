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
            string[] colors = { "red", "blue", "green" };
            Console.WriteLine("Choose an index for the colors Array.");
            int userColor = Convert.ToInt32(Console.ReadLine());
            while (userColor > (colors.Length - 1))
            {
                Console.WriteLine("Please choose a value between 0 and 2.");
                userColor = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("This is the chosen color: " + colors[userColor]); ;


            int[] numbers = { 5, 10, 15, 20 };
            Console.WriteLine("Choose an index for the numbers Array.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            while (userNum > 3) 
            {
                Console.WriteLine("Please choose a value between 0 and " + numbers.Length +".");
                userNum = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("This is the chosen number: " + numbers[userNum]);
            

            List<string> colors2 = new List<string>();
            colors2.Add("Yellow");
            colors2.Add("Brown");
            colors2.Add("Pink");

            Console.WriteLine("Choose an index for the colors2 List.");
            int userColor2 = Convert.ToInt32(Console.ReadLine());
            while (userColor2 > (colors2.Count - 1))
            {
                Console.WriteLine("Please choose a value between 0 and 2.");
                userColor2 = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("This is the chosen color: " + colors2[userColor2]); ;

            Console.ReadLine();

        }
    }
}
