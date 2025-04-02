using InterfaceExample.Humanity;
using InterfaceExample.Interfaces;
using InterfaceExample.Models;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string name = "stitcH";

            //name=Person.Capitalize(name);




            Person person = new Person { Name = "Fatime", Surname = "Qarayeva", Age = 20 };

            Person person2 = new Person { Name = "Ibrahim", Surname = "Mammadaliyev", Age = 21 };
            Person person3 = new Person { Name = "Rena", Surname = "Mammadova", Age = 19 };
            Person person4 = new Person { Name = "Ali", Surname = "Valiyev", Age = 21 };

            person.GetInfo();
            person2.GetInfo();
            person3.GetInfo();
            person4.GetInfo();
            //person.GetInfo();
            //person2.GetInfo();  
            //Console.WriteLine(Person.WorkAge);








            //Cow cow = new Cow {AvgLifeTime=10,Gender="male" };
            //Dog dog = new Dog {AvgLifeTime=11,Gender="female",Name="stitch" };

            //Animal[] ferma = { cow, dog };

            //for (int i = 0; i < ferma.Length; i++)
            //{

            //    Console.WriteLine(ferma[i].AvgLifeTime);
            //}
            //Duck duck=new Duck();
            //Eagle eagle = new Eagle {AvgLifeTime=25,Gender="male",FlySpeed=120,HasEgg=false };


            //Penguin penguin = new Penguin { SwimSpeed=70};

            //Plane plane = new Plane();
            //Ship ship = new Ship();

            //IFly[] flyables =  { eagle, plane, duck};
            //ISwim[] swimables = { penguin, ship, duck };



        }
    }
}
