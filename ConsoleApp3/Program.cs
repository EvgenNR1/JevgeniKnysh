using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 5;
            int y = 10;
            bool m = (x == y);
            switch (m)
            {
                case true:
                    Console.WriteLine("X and Y are equal");
                        break;
                case false:
                    Console.WriteLine("X and Y are not equal");
                        break;
            }

            //list spisok
            int[] numbers = { 1, 0, -2, 10 };
            List<int> numberList = new List<int> { 1, 0, -2, 10 };
            numberList.Add(5);

            int firstNumber = numbers[0];
            Console.WriteLine(firstNumber);

            int firstListElement = numberList[0];
            Console.WriteLine(firstListElement);

            int element = numberList[4];
            Console.WriteLine(element);
            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);

            }
            /*Console.WriteLine("number");
            for (int i = 0; i < numberList.Count; i++);
            {                
                Console.WriteLine(numberList[i]);
            }*/
            Console.WriteLine("Next");
            int index = 0;
            while(index < numberList.Count)
            {
                Console.WriteLine(numberList[index]);
                //index++;
                index += 2; // каждый шаг прибавляем +2 и выдергиваем каждый из списка
            }

            Food sweets = new Food("Sweets", 5);
            Console.WriteLine(sweets.Name+" "+sweets.Price);

            sweets.Price = 6;
            Console.WriteLine(sweets.Name + " " + sweets.Price);

            Food potato = new Food("Potato", 10);
            Console.WriteLine(potato.Name + " " + potato.Price);
            Food tomato = new Food("Tomato", 15);
            Console.WriteLine(tomato.Name + " " + tomato.Price);

            Food[] groceries = { sweets, potato, tomato};
            Console.WriteLine(groceries[1].Name);
            Console.WriteLine(groceries[2].Name);
            Console.WriteLine(groceries[2].Name + " "+groceries[2].Price);

            ShoppingCart myCart = new ShoppingCart();
            myCart.AddToCart(sweets, 3);
            myCart.AddToCart(potato, 5);
            myCart.AddToCart(tomato, 1);
            Console.WriteLine("Total "+ myCart.Sum);

            DetailedShoppingCart Cart = new DetailedShoppingCart();
            





            //Food sweet = new Food();

            Console.ReadLine();
        }
    }
}
