using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample.Utilities.Exceptions
{
    internal class NotFoundException:Exception
    {
        public static string CusMessage { get; set; } = "Tapilmadi";
        public NotFoundException():base(CusMessage)
        {
            
        }
        public NotFoundException(string message) : base(message)
        {

        }

    }
}
