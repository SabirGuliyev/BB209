using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Humanity
{
    internal class Person
    {

        //public static int WorkAge { get; set; } 
        public static int Count=0;
        public  int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Count++;
            Id = Count;
          
        }
        // static Person()
        //{
        //    Console.WriteLine("Static ctor ishe dushdu");
        //    WorkAge = 18;
        //}

        public  void GetInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname} {Age} ");

        }

        public static string Capitalize(string name)
        {
          
            return name.Substring(0,1).ToUpper()+name.Substring(1).ToLower();
        }
    }
}
