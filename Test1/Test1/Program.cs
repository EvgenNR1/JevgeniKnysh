using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    public class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("if yo want see list, press a\nif yo want add to list, press b\nif yo want remove from list, press c\nsee full list of students press d\n");
                char a = (char)Console.Read();
                char b = (char)Console.Read();
                char c = (char)Console.Read();
                char d = (char)Console.Read();
                Console.ReadLine();

                if (Char.IsLetter(a))
                {
                    Console.WriteLine("Please add new student...");
                    List<StudentList> students = new List<StudentList>();
                    Console.WriteLine("Please enter student name!");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please enter student lastname!");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Please enter student personal code!");
                    string personalCode = Console.ReadLine();
                    Console.WriteLine("Student is studying? ");
                    string isStudying = Console.ReadLine();
                    Console.WriteLine("Student status...");
                    string status = Console.ReadLine();

                    StudentList student = new StudentList(firstName, lastName, personalCode, isStudying, status);

                    Console.WriteLine("New student added " + student);

   

                }
                else if (Char.IsLetter(b))
                {
                    Console.WriteLine("Add new student...");

                }
                else if (Char.IsLetter(c))
                {
                    Console.WriteLine("Remove student...");

                }
                else if (Char.IsLetter(d))
                {
                    Console.WriteLine("Full list of students");
                }

            }
        }
    }
}
