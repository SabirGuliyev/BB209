using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP
{
    internal class Eagle : Bird, IFly
    {
        public int Age { get; set; }
        public int FlySpeed { get ; set; }
        public int SwimSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            Console.WriteLine("Flied away");
        }

        public override void Eat()
        {
            if (Age < 5)
            {
                Console.WriteLine("Eat warms");
            }
            else
            {
                Console.WriteLine("Meat");
            }
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
