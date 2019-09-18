using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Class_food
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Class_food(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
