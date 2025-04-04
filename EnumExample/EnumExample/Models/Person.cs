using EnumExample.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample.Models
{
    internal class Person
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public Person(string name,Gender gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}
