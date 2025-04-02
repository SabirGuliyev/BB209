using InterfaceExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Ship : ISwim
    {
        public int SwimSpeed { get ; set ; }

        public void Swim()
        {
            Console.WriteLine("thu");
        }
    }
}
