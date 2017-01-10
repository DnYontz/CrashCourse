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

            // Give the user directions (1-5)
            Console.WriteLine("Pick a number (1-5):");

            // Set winning numbers
            const int winningNumber1 = 3;
            const int winningNumber2 = 5;

            // Get data from the user
            String userData = Console.ReadLine();

            // Convert it to int
            int userValue;
            int.TryParse(userData, out userValue);
            
            // Do they match?
            switch(userValue)
            {
                case winningNumber1:
                    Console.WriteLine("You Win!");
                    break;
                case winningNumber2:
                    Console.WriteLine("You kinda win!");
                    break;
                default:
                    Console.WriteLine("You definitely lose.");
                    break;
            }






            Console.Read();
        }
    }
}
