using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.OCP
{
    internal class Chef
    {
        public void CookMeal(IMeal meal)
        {
            meal.Cook();
        }
    }
}
