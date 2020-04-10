using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Person
    {
        public string mName { get; set; }
        public int mAge { get; set; }
        public Person(string Name, int Age)
        {
            mName = Name;
            mAge = Age;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} and age : {1}", mName, mAge);
        }
    }
}
