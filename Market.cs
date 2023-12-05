using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliforhandler
{
    public class Market
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the dealership. Would you like to see the current inventory or will you manually search? (Press 1, 2 or 3) ");
            var userInput = GetIntInput(3, "Not a valid choice!");
            switch (userInput) //create methods for each scenario (show inventory/bring up search function)
            {
                case 1:
                    Console.WriteLine("Dealership inventory");
                    break;
                case 2:
                    Console.WriteLine("Manual search");
                    break;
                case 3:
                    Console.WriteLine("View owned cars (own garage)");
                    break;
            }
        }
        private static int GetIntInput(int max, string errorMessage = "Not a valid choice!")
        {
            var input = Console.ReadLine();
            try
            {
                var number = int.Parse(input);
                if (number >= 0 && number <= max) return number;
                Console.WriteLine(errorMessage);
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number, try again.");
            }
            return GetIntInput(max);
        }

    }
}
