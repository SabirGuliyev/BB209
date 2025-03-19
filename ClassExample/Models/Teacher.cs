using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample.Models
{
    internal class Teacher : Person
    {


        public byte Experience;
        public decimal Salary;

        public Teacher(string name):base(name)
        {
            
        }

    }
}
