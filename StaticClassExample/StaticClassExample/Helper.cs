using StaticClassExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal static class Helper
    {
        private static int MinSalary=350;
        public static string Capitalize(this string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }
        //public static void PlayWithDog(this Dog dog)
        //{
        //    Console.WriteLine(dog.Name);
        //}

        public static int Power(this int num)
        {
            MinSalary += 6;
            return num * num;
        }
        public static int Power(this int num,int power)
        {
            int value = num;
      
            for (int i = 1; i < power; i++) {

               value *= num;
            }
            Console.WriteLine();

            return value;

        }
    }
}
