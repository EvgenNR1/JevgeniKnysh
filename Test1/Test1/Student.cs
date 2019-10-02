using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsStudying { get; set; }

        public Student(string firstName, string lastName,string isStudying )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IsStudying = isStudying;

        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", FirstName, LastName,IsStudying);
        }



    }
}
