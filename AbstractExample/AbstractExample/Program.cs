using AbstractExample.Models;
using AbstractExample.Models.Base;

namespace AbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog()
            {
                AvgLifeTime = 8,
                Gender = "male",
                Name = "Maximus prime"
            };
           

            Cow cow = new Cow
            {
                AvgLifeTime = 10,
                Gender = "female"
            };


            Console.WriteLine(dog);
            //dog.Eat();
            //cow.Eat();
            //Animal animal = new Animal
            //{
            //    AvgLifeTime = 20,
            //    Gender = "male"

            //};


        }


       
    }

    }
