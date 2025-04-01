using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal abstract class Animal
    {

        public int AvgLifeTime { get; set; }
        public string Gender { get; set; }



    
        public void Eat()
        {
            Console.WriteLine("Eat grass");
        }
        public abstract void MakeSound();
        
    }
}
