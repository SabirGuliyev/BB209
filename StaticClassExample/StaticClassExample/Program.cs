using StaticClassExample.Models;
using StaticClassExample.Test;

namespace StaticClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog("tuzik");

            //dog.PlayWithDog();


            //string test = ",sabkdsajgdkas";
            //test.Capitalize();

            //int a = 5;
            //Console.WriteLine(a.Power(4));
         
            PointClass point= new PointClass();
            point.X = 3;
            point.Y = 4;

            PointStruct pointStruct = new PointStruct();
            pointStruct.X = 3;
            pointStruct.Y = 4;


            Test(point);

            Test(ref pointStruct);
     

        }

        public static void Test(PointClass cordination)
        {
            Console.WriteLine(cordination.X);
        }
        public static void Test(ref PointStruct cordination)
        {
            Console.WriteLine(cordination.X);
        }
    }
}
