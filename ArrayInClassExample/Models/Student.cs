using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInClassExample.Models
{
    internal class Student
    {
        private string _name;

        public string Name { 
            get { return _name; }
            set 
            { 
                value=value.Trim();
                if (value.Length >= 3)
                {
                    _name=Capitalize(value);
                }
                
            }
        }

        public string Surname { get; set; }
        public int Age { get; set; }

        public Student(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Age: {Age}");
        }

        public string Capitalize(string name)
        { 
            return name.Substring(0,1).ToUpper() + name.Substring(1).ToLower();
        }
    }
}
