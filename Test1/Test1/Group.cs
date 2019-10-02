using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Group
    {
        public string GroupName { get; set; }
        public string Student{get;set;}
        //public List<Student> Students { get; set; }
        //public List<string> Groups { get; set; }
        //public Group()
        public Group(string groupName)
        {
            this.GroupName = groupName;


        }
        public override string ToString()
        {
            return string.Format("{0}", GroupName);
        }


        //Students = new List<Student>();
        //Groups = new List<string>();
    }
}
