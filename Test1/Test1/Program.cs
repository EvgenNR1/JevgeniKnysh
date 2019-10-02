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
                    List<Student> studentName = new List<Student>
                    {
                        new Student("Bob","Marley","yes"),

                    };
                    Console.WriteLine("\nPlease add new student...");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("\nPlease enter lastname...");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("\nStudent is studuyin? ");
                    string isStudying = Console.ReadLine();
                    /////
                    ///
                    Student oneStudent = new Student(firstName, lastName, isStudying);
                    Console.WriteLine("Student added " + oneStudent);

                    //oneStudent.Group= new Group();
                    Console.ReadLine();
                    /////////////////////////////////////////////

                    List<Group> newBaseGroup = new List<Group>
                        {
                        new Group("TARgv18"),

                        };

                    Console.WriteLine("\nPlease add new group to the student ");
                    string groupName = Console.ReadLine();

                    Group newGroup = new Group(groupName);
                    Console.WriteLine("Group added " + newGroup);
                    Console.WriteLine("Group " + newGroup + " student " + oneStudent);
                    Console.ReadLine();





                Group_base newList= new Group_base();
                Console.WriteLine(newList);
                Console.ReadLine();
            }
        }
        
        
    }
}
