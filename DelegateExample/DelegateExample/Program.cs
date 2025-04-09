using System.Threading.Channels;

namespace DelegateExample
{
    //public delegate bool CheckNum(ref int num);


    //public delegate void Print(string text);
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 11, 15, 20, 21,42 };
         

            //CheckNum check = delegate (int num)
            //{
            //    return num % 7 == 0 && num % 3 == 0;
            //};


            //CheckNum lambda = x =>x%7==0;



            Console.WriteLine();

            //Console.WriteLine(Sum(numbers,));



           



            //Action<string> action = x => Console.WriteLine(x.ToUpper());

            //action += x => Console.WriteLine(x.ToLower());

            //action("SabIR");






            Console.WriteLine(Sum(numbers,x=>x%2==0 ));
            Console.WriteLine(Sum(numbers,x=>x%2!=0 ));
            Console.WriteLine(Sum(numbers,x=>x%3==0 ));



            //Print print = PrintUpper;
            //print += PrintLower;
            //print += PrintCapitalize;
            //print -= PrintCapitalize;

            //print("sAbIr");


            //Print print = delegate (string test)
            //{
            //    Console.WriteLine(test[0] + " " + test[test.Length - 1]);
            //};

            //print("Sabir");



            //Func<int, bool> test = CheckOdd;

            //Func<int, int, bool> test2 = (x, y) => x > y;

            //Func<string, char> test3 = x => x[0];







        }


        public static int Sum(int[] arr,Predicate<int> func)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (func(arr[i]))
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
        //public static bool CheckEven(int num)
        //{
        //    return num % 2 == 0;
        //}
        //public static bool CheckOdd(int num)
        //{
        //    return num % 2 != 0;
        //}
        //public static bool CheckDivideByThree(int num)
        //{
        //    return num % 3 == 0;
        //}














        //public static void PrintUpper(string name)
        //{
        //    Console.WriteLine(name.ToUpper());
        //}
        //public static void PrintLower(string name)
        //{
        //    Console.WriteLine(name.ToLower());
        //}
        //public static void PrintCapitalize(string name)
        //{
        //    Console.WriteLine(name.Substring(0,1).ToUpper()+name.Substring(1).ToLower());
        //}



















       
    }
}
