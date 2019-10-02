using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    class Group_base
    {
        public List<Student> Studentss { get; set; }
        public List<Group> GroupSS { get; set; }
        public Group_base()
        {
            Studentss = new List<Student>();
            GroupSS = new List<Group>();
        }
        public void AddtoGroup(Student Students, Group GroupS)
        {
            Studentss.Add(Students);
            GroupSS.Add(GroupS);
            
        }
        public override string ToString()
        {
            return Studentss + " " + GroupSS;
        }


    }
}
