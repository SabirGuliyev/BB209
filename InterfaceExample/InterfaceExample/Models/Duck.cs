using InterfaceExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Duck : Bird,IFly,ISwim
    {
        public int FlySpeed { get; set; }
        public int SwimSpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("Duck ucdu");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Duck sounds");
        }

        public void Swim()
        {
            Console.WriteLine("Duck uzdu");
        }
    }
}
