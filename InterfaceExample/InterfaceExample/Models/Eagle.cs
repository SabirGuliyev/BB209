﻿using InterfaceExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Eagle : Bird,IFly
    {
        public int FlySpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("Eagle flied away");
        }

        public override void MakeSound()
        {
            Console.WriteLine("qagq");
        }
    }
}
