using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample.RecordExample
{
    internal record PersonRecord
    {
        private string _name;
        public string Name
        {
            get
            { return _name; }

            init
            { _name = value; }
        }

        //public PersonRecord(string name)
        //{
        //    _name = name;
        //}
    }
}
