using System.Threading.Channels;

namespace MethodExample
{
    internal class Program
    {

        static void Main(string[] args)
        {


            //int price = 90;
            //int percent = 10;
            //Console.WriteLine(product*percent/100);

            //int result= GetDiscount(140,10);
            // Console.WriteLine(result);


            // Console.WriteLine(GetDiscount(100, 20));
            //Console.WriteLine(IsEven(10)); 

            //bool result = true;
            //int num = 0;
            //Console.WriteLine(result);
            //Console.WriteLine(num);


            //GetFullname("Fatime");

            //string[] arr = { "Salam", "Quiz", "gelir", "r.i.p." };

            //GetSentence(arr);
            //Console.WriteLine();
            //GetSentence("salam", "kesileceksiz", "dgd");
            //Sum(5, 7, 8);
            //Sum(5);
            //Sum(5,6);

            //Sum(5d);



            //Sum(0,10);
        }
      
        //public static void Sum(int num)
        //{
        //    Console.WriteLine("1ci");
        //}
        //public static void Sum(int num,int num2=10)
        //{
        //    Console.WriteLine("2ci");
        //}

        //public static void Sum(params int[] nums)
        //{
        //    Console.WriteLine("3cu");
        //}



        public static void GetSentence(params string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]+" ");
            }
        }






        public static void GetFullname(string name, string surname = "xxx")
        {
            Console.WriteLine(name+" "+surname);
        }





        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static int GetDiscount(int price,int percent)
        {
            return price * percent / 100;

        }

    }
}
