using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal sealed class Dog:Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Raff raff");
        }

        //new public void Eat()
        //{
        //    Console.WriteLine("sadasd");
        //}
        public sealed override void Eat()
        {
            Console.WriteLine("Eat vegetables and meat");
        }
        public void PlayWithHuman()
        {
            Console.WriteLine("topu getir");
        }


        public override string ToString()
        {
            return $"{Name} {AvgLifeTime}";
        }
    }
}
