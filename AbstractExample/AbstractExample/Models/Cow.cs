﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Cow:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Mooo");
        }

        public override string ToString()
        {
            return $"{AvgLifeTime} {Gender}";
        }
        public void ProduceMilk()
        {
            Console.WriteLine("Milk produced");
        }
    }
}
