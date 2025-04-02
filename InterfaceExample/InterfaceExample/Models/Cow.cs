using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Cow : Animal
    {
        public void ProduceMilk()
        {
            Console.WriteLine("milk");
        }
        public override void MakeSound()
        {
            Console.WriteLine("mooooo");
        }
    }
}
