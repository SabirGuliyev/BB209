using System.Reflection;
using UpcastingExample.Currencies;
using UpcastingExample.Models;

namespace UpcastingExample
{
    internal interface ITestable;
    internal struct Test:ITestable
    {
        public int X { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
            
        {
            #region Type Conversion
            //checked unchecked istifade edilmelidir
            //int b = 500;
            //byte a =(byte) b;
            //Console.WriteLine(a);

            #endregion

            #region Reflection

            //    Assembly assembly = Assembly.GetExecutingAssembly();

            //   Type[] types=assembly.GetTypes();

            //FieldInfo
            //PropertyInfo
            //MethodInfo
            //ConstructorInfo

            //foreach (Type type in types)
            //{
            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine(type.Name);
            //    MemberInfo[] members = type.GetMembers();

            //    foreach (MemberInfo member in members)
            //    {
            //        Console.WriteLine(member.Name);
            //    }
            //}

            //Teacher teacher = new Teacher();


            //Type type = teacher.GetType();
            //string name=nameof(Student.GetInfo);

            //    foreach(var member in type.GetMembers())
            //{
            //    Console.WriteLine(member.Name);
            //}

            //Type type2 = typeof(Teacher);
            //Type type3 = assembly.GetType("UpcastingExample.Models.Teacher");


            //var field= type.GetField("_salary",BindingFlags.NonPublic|BindingFlags.Instance);

            //  field.SetValue(teacher, 123456m);





            //  Console.WriteLine(field.GetValue(teacher)); 
            #endregion


            #region Boxing, Unboxing


            //Test test = new Test();
            //ITestable testable = test;

            //Test test2 = (Test)testable;


            // int num = 5;
            // object obj = num;


            //int num2 = (int)obj; 
            #endregion


            #region Upcasting, Downcasting

            //Dog dog = new Dog { AvgLife = 8, Gender = "male", Name = "Rex" };
            //Eagle eagle = new Eagle {AvgLife=28,Gender="female",ClawPower=400 };

            //Animal[] animals = { dog, eagle };



            //foreach (var animal in animals) 
            //{
            //    Console.WriteLine(animal.Gender);

            //    //is ile cast
            //    if (animal is Dog d)
            //    {
            //        //Dog dog2=(Dog)animal;
            //        Console.WriteLine(d.Name);
            //    }
            //    if(animal is Eagle e)
            //    {
            //        Console.WriteLine(e.ClawPower);
            //    }


            //}



            //implicit casting
            //Animal animal = new Eagle { AvgLife = 8, Gender = "male" };



            //explicit casting
            //Dog dog =(Dog)animal;



            //As operator casting
            //Dog dog =animal as Dog;

            //if(dog != null)
            //{
            //    Console.WriteLine(dog.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Yanlish casting emeliyyati");
            //}


            //Console.WriteLine(animal.AvgLife);
            //foreach(Animal animal in animals)
            //{

            //}

            #endregion




            //Manat manat = new Manat(340);
            //Manat manat2 = new Manat(370);

            //Dollar dollar = new Dollar(100);


            //manat  += 200;

            //Console.WriteLine(manat.AZN);







            //Manat manat2 = dollar;

            //Dollar dollar2 = manat;

            //Console.WriteLine(dollar2.USD);

            //Manat manat3 = 300m;
            //Console.WriteLine(manat3);




        }
    }
}
