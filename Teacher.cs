using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Teacher : Person
    {
        public string TeacherId;
        public string Subject;
        public Teacher(string Name, int Age, string mTid, string mSubject)
            : base(Name, Age)
        {
            mName = Name;
            mAge = Age;
            mTid = TeacherId;
            mSubject = Subject;
        }
    }
}