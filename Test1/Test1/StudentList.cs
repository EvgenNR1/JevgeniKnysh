using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class StudentList
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalCode { get; set; }
        public string IsStudying { get; set; }
        public string Status { get; set; }
        public StudentList(string firstName, string lastName, string personalCode, string isStudying, string status )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PersonalCode = personalCode;
            this.IsStudying = isStudying;
            this.Status = status;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", FirstName, LastName, PersonalCode, IsStudying, Status);
        }



    }
}
