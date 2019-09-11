using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; } //properties большими буквами

        public Food(string name, int price)// а тут маленькими буквами
        {
            Name = name;
            Price = price;

        }
        
        

    }
}
