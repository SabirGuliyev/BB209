using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.DIP
{
    internal class Paw : ICut
    {
        public void Cut()
        {
            Console.WriteLine("Cut by paw");
        }
    }
}
