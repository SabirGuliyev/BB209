using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample.Models
{
    internal class Student:Person
    {
      

        public byte Grade;
        public string Faculty;

        public Student(string name):base(name)
        {
            Console.WriteLine("Student ctor ishe dushdu");
        }



    }
}
