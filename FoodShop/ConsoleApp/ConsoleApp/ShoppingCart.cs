using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class ShoppingCart
    {
        public List<Class_food> Items { get; set; }
        public List<int> Amounts { get; set; }
        public double Sum { get; set; }
        public ShoppingCart()
        {
            Items = new List<Class_food>();
            Amounts = new List<int>();
            Sum = 0;
        }
        public void AddtoCart(Class_food food, int amount)
        {
            Items.Add(food);
            Amounts.Add(amount);
        }

        public double CalculateSum()
        {
            for (int i = 0; i<Items.Count(); i++)
            {
                Sum = Sum + Items[i].Price * Amounts[i];
            }
            return Sum;

        }
    }
}
