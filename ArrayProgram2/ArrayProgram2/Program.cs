using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "one", "two", "three" }; //create array
            Console.WriteLine("Please input some text to add to the strings in the array."); //asking for input
            string input = Console.ReadLine(); //storing the response
            for (int i = 0; i < words.Length; i++) //for loop to iterate through arrray
            {
                words[i] = words[i] + input; //adds the input to the string at "i" in the array
                Console.WriteLine(words[i]); //adds the result to the display
            }
            


            List<string> cars = new List<string>() { "Ford", "Chevy", "Honda" }; //create list
            Console.WriteLine("Search for your car."); //asking for input
            string userCar = Console.ReadLine(); //storing variable
            //while (!cars.Contains(userCar))
            //{
            //    Console.WriteLine("Sorry your car isn't on the list.");
            //    userCar = Console.ReadLine();
            //}
            //Console.WriteLine(cars.IndexOf(userCar));
            foreach (string car in cars) //iterating through the list
            {
                if (car == userCar)
                {
                    Console.WriteLine(cars.IndexOf(car)); //if the input is equal to the value in the array then write the index at point "car"
                }
            }
            if (!cars.Contains(userCar)) 
            {
                Console.WriteLine("Sorry your car isn't on the list."); //if the input isnt found in the list then display this
            }



            List<string> cars2 = new List<string>() { "Chevy", "Ford", "Honda", "Ford" }; //create list
            Console.WriteLine("Search for your car."); //ask for input
            string userCar2 = Console.ReadLine(); //store variable
            for (int car2 = 0; car2 < cars2.Count; car2++) //iterate through the list
                if (userCar2 == cars2[car2]) //if the input is euqal to the point in the list
                {
                    Console.WriteLine(car2); //write the index of the car
                }
            if (!cars2.Contains(userCar2))
            {
                Console.WriteLine("Sorry your car isn't on the list."); //if the input isnt found in the list then display this
            }



            List<string> fruits = new List<string>() { "Apple", "Banana", "Apple", "Orange", "Apple", "Banana" }; //create list
            List<string> appeared = new List<string>(); //create empty list for use later
            foreach (string fruit in fruits) //iterate through "fruits" list
            {
                if (appeared.Contains(fruit)) //this if/else adds to the list if the value has not yet been added, however if it has already been added then it will just didplay the string
                {
                    Console.WriteLine(fruit + " has already appeared.");
                }
                else
                {
                    appeared.Add(fruit);
                    Console.WriteLine(fruit);
                }
            }
            Console.ReadLine();

        }
    }
}
