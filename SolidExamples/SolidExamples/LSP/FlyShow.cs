using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP
{
    internal class FlyShow<T> where T : Bird,IFly, new()
    {
        T _bird=new T();

        public void Start()
        {
            _bird.Fly();
        }
    }
}
