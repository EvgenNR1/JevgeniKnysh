using ConsoleApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FauvoriteColorr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            //string[] lines = File.ReadAllLines(@"C:\Users\Evgeny\Desktop\Names.txt");
            string[] lines = File.ReadAllLines("Names.txt");
            

            foreach(var line in lines)
            {
                var names = line.Split(" ");
                Person person = new Person(names[0], names[1]);
                people.Add(person);
            }

            Console.WriteLine("Hi, Please enter your last name: ");
            string lastName = Console.ReadLine();
            Person someone = people.FirstOrDefault(x => x.LastName == lastName);
            Console.WriteLine($"Hi, {someone.FirstName}! What's your favourite color? ");
            var answer = Console.ReadLine();
            Enum.TryParse(answer, true, out Color favouriteColor);
            someone.FauvoriteColorr = favouriteColor;

            using (StreamWriter file = new StreamWriter("list2.txt"))
            {
                file.WriteLine($"{someone.FirstName}{someone.LastName} Favourite color: {someone.FauvoriteColorr}");
            }

        }
    }
}
