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
                    Console.WriteLine("Here's what we have in stock!\n");
                    Program.CarsList();
                    break;
                case 2:
                    Console.WriteLine("What criteria would you like to search with?\n");
                    SearchChoices();
                    break;
                case 3:
                    Console.WriteLine("View owned cars (own garage)");
                    break;
            }
        }

        private static void SearchChoices()
        {
            Console.Write("1. Model, ");
            Console.Write("2. Year ");
            Console.Write("3. Kilometer\n\n");
            var userSearchChoice = SearchChoiceInput(3, "Not a valid choice!");
            switch (userSearchChoice)
            {
                case 1:
                    Console.WriteLine("You chose to search by model!");
                    break;
                case 2:
                    Console.WriteLine("You chose to search by year!");
                    break;
                case 3:
                    Console.WriteLine("You chose to search by kilometer!");
                    break;
            }
            static int SearchChoiceInput(int max, string errorMessage = "Not a valid choice!")
            {
                var userSearchChoice = Console.ReadLine();
                try
                {
                    var number = int.Parse(userSearchChoice);
                    if (number >= 0 && number <= max) return number;
                    Console.WriteLine(errorMessage);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number, try again.");
                }
                return SearchChoiceInput(max);
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
