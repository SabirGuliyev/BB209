using GenericExample.Models.Animals;
using GenericExample.Models.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample.Models
{
    internal class ZooCage<T,U> where T:Animal,new()
                                where U : Food,new()
    {
        private T[] _animals=new T[0];
        public T[] Animals { get => _animals; set => _animals = value; }

        public U Food { get; set; }

        public ZooCage(U food)
        {
            Food = food;
        }

        public void Add(T animal)
        {
            Array.Resize(ref _animals, Animals.Length + 1);
            Animals[Animals.Length-1] = animal;
        }

        public void ShowAnimals()
        {
            foreach (T animal in Animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
