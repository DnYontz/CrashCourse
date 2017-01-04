using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Danielle";
            int number = 25;
            char letter = 'a';
            double doubleNumber = 5.5;
            bool myBoolean = true;


            Console.WriteLine("Name: " + name);
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Letter: " + letter);
            Console.WriteLine("Decimal Number: " + doubleNumber);
            Console.WriteLine("Boolean: " + myBoolean);

            String height = "50";

            int parsedValue;
            int.TryParse(height, out parsedValue);

            if (parsedValue > 200)
            {
                Console.WriteLine("Yay! Tall!");
            }
            else
            {
                Console.WriteLine("Boo! Short!");
            }



            Console.WriteLine("Pick a number: 1-3: ");
            string userInput = Console.ReadLine();

            // int parsedValue;
            int.TryParse(userInput, out parsedValue);
            int winningNumber = 2;

            if (parsedValue == winningNumber)
            {
                Console.WriteLine("You Won! Your number was the winning number!");
            }
            else
            {
                Console.WriteLine("Your number was not the winning number!");
            }
            Console.Read();
        }
    }
}
