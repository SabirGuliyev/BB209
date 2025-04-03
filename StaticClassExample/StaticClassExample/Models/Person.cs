using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample.Models
{
    internal class Person
    {
        public static int Count { get; set; }
        public static int WorkAge { get; set; }
        public string Name { get; set; }
        public Person(string name)
        {
            
            //Name=Helper.Capitalize(name);
            Name=name.Capitalize();
        }
       
    }
}
