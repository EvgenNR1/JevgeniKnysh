﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
