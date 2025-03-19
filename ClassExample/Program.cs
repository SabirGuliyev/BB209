using ClassExample.Models;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Class Ctor


            //object person = new
            //{
            //    Name = "Fatime",
            //    Surname = "Qarayeva",
            //    Age = 20

            //};

            //object person2 = new
            //{

            //    Fullname = "Qasimzade",
            //    Age = 19

            //};

            //Console.WriteLine(person.GetType().GetProperty("Name").GetValue(person));


            //Person person = new Person("Turane");

            //person.GetInfo();






            //Person person2 = new Person()
            //{

            //    Age = 19,
            //    IsMarried = false
            //};



            //person2.GetInfo();


            //person.GetInfo();







            //Console.WriteLine("{0} {1} {2}",person.Name,person.Surname,person.Age);



            //Person person3 = new Person("Turane","Qasimzada",19,false);



            //Person person = new Person();

            //Person person2= new Person("Fatime");

            //Person person3 = new Person("Turane", "Gasimzade"); 
            #endregion


            Student student = new Student ("Sunay"){
          
            Surname="Kazimbeyli",
            Age=20,
            IsMarried=false,
            Faculty="Sabah",
            Grade=3
            
            };

            //Teacher teacher = new Teacher {
            //    Name = "Sabir",
            //    Surname = "Guliyev",
            //    Age = 27,
            //    IsMarried = false,
            //    Salary = 76543.90m,
            //    Experience = 3
            //};

            //student.GetInfo();
            //teacher.GetInfo();
        }
    }

    class Person
    {
        //Fields
        public string Name;
        public string Surname;
        public byte Age;
        public bool IsMarried;

        //Constructor -- CTOR

        public Person(string name)
        {
            Console.WriteLine("Person ctor ishe dushdu");
            Name = name;
        }
     
        #region Ctor Overload

        //public Person()
        //{
        //    Console.WriteLine("Person created");
        //}


        //public Person(string name):this()
        //{
        //    Name = name;
        //}
        //public Person(string name,string surname):this(name)
        //{
        //    Surname = surname;
        //}

        //public Person(string name, string surname,byte age):this(name,surname)
        //{
        //    Age = age;
        //}
        //public Person(string name, string surname, byte age,bool isMarried):this(name,surname,age)
        //{
        //    IsMarried=isMarried;

        //} 

        //public Person(string name,string surname="xxx")
        //{
        //    Name=name;  
        //    Surname=surname;

        //    //Email = name + "." + surname + "@code.edu.az";



        //}
        #endregion


        //Methods

        public void GetInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Age:{Age} Marriage status:{IsMarried}");
        }

    }
}
