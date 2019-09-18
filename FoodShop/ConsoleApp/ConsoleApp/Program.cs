using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //shop
            List<Class_food> groceries = new List<Class_food>
            {
                new Class_food("banana",1.2),
                new Class_food("potatoes", 1),
                new Class_food("icecream", 2.5)
            };
            //Client
            Console.WriteLine("Please enter your first name!");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hi, " + firstName + "! Please enter your lastname");
            string lastName = Console.ReadLine();

            Person client = new Person(firstName, lastName);

            Console.WriteLine("Welcome to our shop, " + client);

            client.ShoppingCart = new ShoppingCart();

            ChooseFood(groceries, client);
            while (Console.ReadLine() == "Y")
            {
                ChooseFood(groceries, client);
            }
            double sum = client.ShoppingCart.CalculateSum();
            Console.WriteLine("Your total is " + sum + " Thank you for visiting! ");
            Console.ReadLine();
        }

        private static void ChooseFood(List<Class_food> groceries, Person client)
        {
            Console.WriteLine("What do you want to buy?");
            string foodName = Console.ReadLine();
            Class_food chosenFood = groceries.FirstOrDefault(x => x.Name == foodName);
            if (chosenFood == null)
            {
                Console.WriteLine("Sorry, no food " + foodName + " in our candy shop");
            }
            else
            {
                Console.WriteLine("How much do you want? ");
                string amount = Console.ReadLine();
                int a;
                bool success = int.TryParse(amount, out a); // 
                while (!success)
                {
                    Console.WriteLine("Sorry, amount should be integer value: ");
                    amount = Console.ReadLine();
                    success = int.TryParse(amount, out a);

                }
                client.ShoppingCart.AddtoCart(chosenFood, a);
                //Console.WriteLine("Anything else? Y/N");
            }
            Console.WriteLine("Anything else? Y/N");
            
        }
    }
}
