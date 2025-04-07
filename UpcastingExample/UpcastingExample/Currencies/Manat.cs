using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingExample.Currencies
{
    internal class Manat
    {
        public decimal AZN { get; set; }

        public Manat(decimal azn)
        {
            AZN = azn;
        }



        public static bool operator >=(Manat manat,Manat manat2)
        {
            return manat.AZN>=manat2.AZN;
        }
        public static bool operator <=(Manat manat, Manat manat2)
        {
            return manat.AZN <= manat2.AZN;
        }

        public static Manat operator +(Manat manat1, Manat manat2)
        {

            manat1.AZN += manat2.AZN;
            return manat1;
        }
        //public static Manat operator +(Manat manat1, decimal value)
        //{

        //    manat1.AZN +=value ;
        //    return manat1;
        //}


        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.USD * 1.7m);
        }
        public static implicit operator Manat(decimal value)
        {
            return new Manat(value);
        }
    }
}
