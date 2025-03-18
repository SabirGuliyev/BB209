namespace StackHeapExample
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //if (true)
            //{
            //    int num = 6;

            //    if (true)
            //    {
            //        int test = 9;

            //        if (true)
            //        {
            //            int sum = 30;
            //        }
            //    }
            //}

            //int a = 5;
            //int b = a;
            //b += 10;

            //Console.WriteLine(a);



            //int[] arr = { 1, 2, 3 };

            //int[] arr2 = arr;
            //arr2[0] = 500;


            //Console.WriteLine(arr[0]);



            //int[] nums = { 1, 2, 3 };
            //SumArr(nums);

            //Console.WriteLine(nums[0]);












            //int[] nums = new int[4];
            //int[] nums2 = new int[4] {1,2,3,4 };
            //{0,0,0,0 }

            //int[] nums = { 1, 2, 3, 4 };
            //ResetArray(ref nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}






            //int a;
            //Sum(out a);

            //Console.WriteLine(a);











            //Console.WriteLine("Reqem daxil edin please:");
            //string str=Console.ReadLine();

            //int num;
            //bool result = int.TryParse(str, out num);




            



            int[] nums = { 1, 2, 3 };


            Array.Resize(ref nums, nums.Length + 1);
            nums[nums.Length - 1] = 40;


            ///new int[]{0,0,0,0}

            CustomResize(ref nums, 4);
            CustomResize(ref nums, 5);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

        }

        public static void CustomResize(ref int[] arr,int num)
        {   //1 2 3 0
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++) 
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = num;

            arr= newArr;

           

        }









        //public static void Sum(out int num)
        //{
        //    num = 0;
        //    num += 20;

        //}
















        //0x001
        //public static void ResetArray(ref int[] arr)
        //{
        //    arr = new int[arr.Length];
        //}











        public static void SumArr(int[] arr) 
        {
            arr[0] += 20;

        }

       
    }
}
