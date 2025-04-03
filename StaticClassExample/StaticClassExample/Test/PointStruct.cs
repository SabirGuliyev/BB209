using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample.Test
{
    internal struct PointStruct:IEnumerable<PointStruct>
    {
        public int X { get; set; } 
        public int Y { get; set; }
        public PointStruct()
        {
          
        }

        public IEnumerator<PointStruct> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
