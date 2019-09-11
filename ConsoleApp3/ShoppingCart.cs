using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ShoppingCart
    {
        public int Sum { get; set; }
        public ShoppingCart()
        {
            Sum = 0;
        }
        public void AddToCart(Food food, int amount) //void не возвращает ничего.

        {
            Sum = Sum + food.Price * amount; 
        }


    }
}
