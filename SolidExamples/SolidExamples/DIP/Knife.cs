using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.DIP
{
    internal class Knife:ICut
    {
        public Knife()
        {
            throw new Exception("Broken");
        }

        public void Cut()
        {
            Console.WriteLine("Cut olundu");
        }
    }
}
