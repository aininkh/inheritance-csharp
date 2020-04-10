using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Aquilae", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Selena", 35, "190302", "Algorithm");
            teacher.GetNameAndAge();

            Student student = new Student("Aini", 20, "19112595", "aini.khasanah@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
