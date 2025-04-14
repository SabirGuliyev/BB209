using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.DIP
{
    internal class Pizza
    {
        public string Type { get; set; }
        public ICut Tool { get; set; }
        public Pizza(ICut tool)
        {
            Tool = tool;
        }

        public void ServePizza()
        {
            Tool.Cut();
        }
    }
}
