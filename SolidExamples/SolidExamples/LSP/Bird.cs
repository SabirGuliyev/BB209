using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP
{
    internal abstract class Bird
    {
      
        public virtual void Eat() 
        {

            Console.WriteLine("Grass feeded");
        }
    }
}
